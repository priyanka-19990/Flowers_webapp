document.getElementById('onlyid').addEventListener('click', getId);
function getId() {
    var id = document.getElementById("single_row").value;
    var url = 'http://localhost:56319/api/flowers/' + id;
    fetch(url)
        .then(response => response.text())
        .then(result => display1(result))
        .catch(error => console.log('Error', error));
}
function display1(data) {
    document.getElementById('b1').innerHTML = data;
}


const url = 'http://localhost:56319/api/flowers';
document.getElementById('fulltable').addEventListener('click', get);
function get() {
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };
    fetch(url, requestOptions)

        .then(response => response.text())

        .then(result => display(result))

        .catch(error => console.log('error', error));
}
function display(data) {

    document.getElementById('b1').innerHTML = data;
}


function postdata() {
    let Name = document.getElementById("name");
    let BinomialName = document.getElementById("binomialname");
    let State = document.getElementById("state");
    // Creating a XHR object
    let xhr = new XMLHttpRequest();
    let url = 'http://localhost:56319/api/flowers';
    // open a connection
    xhr.open("POST", url, true);
    // Set the request header i.e. which type of content you are sending

    xhr.setRequestHeader("Content-Type", "application/json");

    // Create a state change callback

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            // Print received data from server

            result.innerHTML = this.responseText;
        }
    };
    // Converting JSON data to string
    var data = JSON.stringify({"name": Name.value, "binomialName": BinomialName.value, "state": State.value });
    // Sending data with the request

    xhr.send(data);

}

function getdata() {
    var id=document.getElementById("like").value;
    var url= 'http://localhost:56319/api/flowers/flowers/' +id;
    fetch(url)
    .then((res) => res.text())
    .then(ans => showData(ans))  
    }
  function showData(data)
  {
      document.getElementById('b1').innerHTML=data;

  }

