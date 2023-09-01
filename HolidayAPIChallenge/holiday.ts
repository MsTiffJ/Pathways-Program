async function getHolidays() {
    // first build the API call string by starting with the URL
    var ApiString = "https://date.nager.at/api/v3/publicholidays/";
    // next add the user parameter to the string using the textbox and add 
    var holidayYear = (<HTMLSelectElement>document.getElementById("newYear")).value;
    ApiString = ApiString + holidayYear + "/US ";
    

    // now use the fetch API to make the HTTP request
    var response = await fetch(ApiString);
    // read the response as JSON since it is a JSON file
    var jsonData = await response.json();

    // Storing data
    alert(jsonData[0].name);

    document.getElementById("holidayDate")!.innerHTML = "";
    document.getElementById("holidayName")!.innerHTML = "";
    document.getElementById("holidayLocalName")!.innerHTML = "";

    for (let i = 0; i < jsonData.length; i++) {
        document.getElementById("holidayDate")!.innerHTML += jsonData[i].date + "<br/>";
        document.getElementById("holidayName")!.innerHTML += jsonData[i].name + "<br/>";
        document.getElementById("holidayLocalName")!.innerHTML += jsonData[i].localName + "<br/>";
    }
}