function verifyThenInsert() {
    var brandNewWord = document.forms["myInputBoxes"]["newWord"].value;
    var brandNewNumber = document.forms["myInputBoxes"]["newNumber"].value;
    /*Verify */
    if (brandNewWord == "") /*Alert to tell the user to enter valid information */ {
        alert("Please enter a word for validation");
        return false;
    }
    else if ((brandNewNumber != 1) && (brandNewNumber != 2)) /*Alert to tell the user to enter valid number 1or2 */ {
        alert("Please enter the number 1 or 2 only");
        document.forms["myInputBoxes"]["newNumber"].value = "";
        return false;
    }
    else {
        if (brandNewNumber == 1) {
            var tableRef = document.getElementById("myListOne");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = brandNewWord;
        }
        else {
            var tableRef = document.getElementById("myListTwo");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = brandNewWord;
        }
        document.forms["myInputBoxes"]["newWord"].value = "";
        document.forms["myInputBoxes"]["newNumber"].value = "";
        return true;
    }
}
/* Method to clear List One */
function clearOne() {
    var tableRef = document.getElementById("myListOne");
    tableRef.innerHTML = " ";
}
function clearTwo() {
    var tableRef = document.getElementById("myListTwo");
    tableRef.innerHTML = " ";
}
