function verifyThenInsert()
/* Method to verify and insert entries */ {
    let brandNewWord = document.forms["myInputBoxes"]["newWord"].value;
    let brandNewNumber = document.forms["myInputBoxes"]["newNumber"].value;

    /*Verify */
    if (brandNewWord == "") /*Alert to tell the user to enter valid information */ {
        alert("Please enter a word to check");
        return false;
    }
    else if ((brandNewNumber != 1) && (brandNewNumber != 2)) /*Alert to tell the user to enter valid number 1or2 */ {
        alert("Please enter the number 1 or 2 only");
        document.forms["myInputBoxes"]["newNumber"].value = "";
        return false;
    }
    else {
        if (brandNewNumber == 1) {
            let tableRef = document.getElementById("myListOne");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = brandNewWord + '-' + PalindromeValidator1(brandNewWord);
        }
        else {
            let tableRef = document.getElementById("myListTwo");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = brandNewWord+ '-' + PalindromeValidator2(brandNewWord);
        }

        document.forms["myInputBoxes"]["newWord"].value = "";
        document.forms["myInputBoxes"]["newNumber"].value = "";
        return true;
    }
}
/* Method to clear List One */
function clearOne() {
    let tableRef = document.getElementById("myListOne");
    tableRef.innerHTML = " ";
}
function clearTwo() {
    let tableRef = document.getElementById("myListTwo");
    tableRef.innerHTML = " ";
}

function PalindromeValidator1 (newWord){
    let wordreversed = newWord.split("").reverse().join("");
    return newWord === wordreversed;
}
function PalindromeValidator2 (newWord)
{
    if(newWord.length %= 2)                                 /* If new word has a remainder (if the number of letters is odd) */
    
    {
        alert("Here 1 odd " + (newWord.length %=2));

        let reversedword = newWord.split("").reverse().slice(0, ((newWord.length-1) / 2)).join(""); /* create a new array with the word, reverse it and split it in half (make the letter count even) */                                                                                                   
        newWord = newWord.split("").slice(0, ((newWord.length-1) / 2)).join("");                    /* create a new array with the word and split it in half (make the letter count even) */  
        return newWord === reversedword;                    /* compare each half to determine if the word is a palindrome */
    }
    else                                                    /* If new word does not have a remainder (if the number of letters is even) */
    {
        alert("Here 2 even " + (newWord.length %=2));
        let reversedword = newWord.split("").reverse().slice(0, (newWord.length / 2)).join("");     /* create a new array with the word, reverse it and split it in half */   
        newWord = newWord.split("").slice(0, (newWord.length / 2)).join("");                        /* create a new array with the word and split it in half */ 
        return newWord === reversedword;                    /* compare each half to determine if the word is a palindrome */
    }
}
