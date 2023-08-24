function verifyThenInsert()
/* Method to verify and insert entries */ 
{
    let brandNewWord : string = document.forms["myInputBoxes"]["newWord"].value;
    let brandNewNumber = document.forms["myInputBoxes"]["newNumber"].value;
    var tableRef: any;
    
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
            tableRef = document.getElementById("myListOne");
            (tableRef?.insertRow(tableRef.rows.length)).innerHTML = brandNewWord;
        }
        else {
            tableRef = document.getElementById("myListTwo");
            (tableRef?.insertRow(tableRef.rows.length)).innerHTML = brandNewWord;
        }

        document.forms["myInputBoxes"]["newWord"].value = "";
        document.forms["myInputBoxes"]["newNumber"].value = "";
        return true;
    }
}
    /* Method to clear List One */
    function clearOne() {
        var tableRef: any;
        tableRef = document.getElementById("myListOne");
        tableRef.innerHTML = " ";
    }
    function clearTwo() {
        var tableRef: any;
        tableRef = document.getElementById("myListTwo");
        tableRef.innerHTML = " ";
    }