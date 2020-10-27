class Comment {
    constructor(username, text, when, postid) {
        this.userName = username;
        this.text = text;
        this.when = when;
        this.postid = postid;
    }
}

// userName is declared in razor page.
const username = userName;
const textInput = document.getElementById('postText');
const whenInput = document.getElementById('when');
const comment = document.getElementById('comment');
const postsQueue = [];
const postid = document.getElementById('postId');

document.getElementById('submitButton').addEventListener('click', () => {
    var currentdate = new Date();
    when.innerHTML =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })
});

function clearInputField() {
    messagesQueue.push(textInput.value);
    textInput.value = "";
}

function sendMessage() {
    let text = postsQueue.shift() || "";
    if (text.trim() === "") return;

    let when = new Date();
    let comment = new Comment(username, text, postid);
    sendMessageToHub(comment);
}

function addMessageToChat(post) {
    let isCurrentUserMessage = comment.userName === username;

    //let container = document.createElement('div');
    //container.className = isCurrentUserMessage ? "container darker" : "container";

    let sender = document.createElement('p');
    sender.className = "sender";
    sender.innerHTML = comment.userName;
    let text = document.createElement('p');
    text.innerHTML = comment.text;

    let when = document.createElement('span');
    when.className = isCurrentUserMessage ? "time-left" : "time-right";
    var currentdate = new Date();
    when.innerHTML =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

    container.appendChild(sender);
    container.appendChild(text);
    container.appendChild(when);
    chat.appendChild(container);
}