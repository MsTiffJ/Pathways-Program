function enterToDo()
/*Method for verifying and entering */ {
    //Declare and inititalize variables(properties)
    let brandNewChore: string = document.forms["myChoreBox"]["newChore"].value; /* Capturing and storing the value from the form entry for the chore */
    let brandNewDate: string = document.forms["myChoreBox"]["newDueDate"].value;/*Capturing and storing the value from the form entry for the date*/
    var tableRef: any;

    /*Verify */
    if (brandNewChore == "")  /* If the user does not enter valid information */ {
        alert("Please enter your next chore"); /* Making sure user enters a valid information for the chore */
        return false; /* keeps a loop as long as valid information is not submitted */
    }
    else if (brandNewDate == "") {
        alert("Please enter a due date for chore"); /*Making sure user enters a due date */
        return false; /* keeps a loop as long as valid information is not submitted */
    }
    else {
        tableRef = document.getElementById("myTaskList"); /* Getting the ID of the table storing the value in the variable  */
        let insertTask = (tableRef.rows.length + 1) + ". " + brandNewChore.concat(" - ", brandNewDate); /*Creating the task string storing it in a variable */
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = insertTask; /*Adding the task string to the table */
    }
    document.forms["myChoreBox"]["newChore"].value = ""; /* Clear the chore box after adding a task */
    document.forms["myChoreBox"]["newDueDate"].value = ""; /* Clear the date box after adding a task */
    return true;
}

/* Method to clear a single Task */
function clearTask() {
    do{                                         /* do while loop to make sure user enter a task number to clear a single task */
    var taskChoice: any = prompt("Please choose a task number to clear"); /*Capturing the number */
    } while(taskChoice == "");

    var tableRef: any;                               /* variable used to store table ID  */
    tableRef = document.getElementById("myTaskList");  /* Getting the ID of the table storing the value in the variable  */
    tableRef.deleteRow(Number(taskChoice) - 1);  /* Deleting the row at the selected index  */
    var str = ""                      /* Variable to capture each row in the table  */
    for (var i = 0; i < tableRef.rows.length; i++) {  /* For loop to restructure the list after deleting a task  */
        str = tableRef.rows[i].innerHTML;  /* store the row in the variable */
        let newTaskName = str.substring(str.indexOf("."));  /* Remove the number in front of the period  */
        let finalTaskName = (tableRef.rows[i].rowIndex + 1) + newTaskName;  /* Add the number in front of period in order to restructure the list  */
        tableRef.rows[i].innerHTML = finalTaskName;  /* add the row to the table  */
    }
}
/*Method to update Task */
function updateTask() {
    var tableRef: any;                            /* variable used to store table ID  */
    tableRef = document.getElementById("myTaskList"); /* Getting the ID of the table storing the value in the variable  */

    do {                                                    /* do while loop to make sure user enter a task number to update  */
        var taskUpdate: any = prompt("Please choose a task number to update"); /* variable used to store task number  */

    } while (taskUpdate == "");

    do {                                                        /* do while loop to make sure user enter a task name to update  */
        var newTaskUpdate: any = prompt("Please enter the new task name"); /* variable used to store task name  */

    } while (newTaskUpdate == "");

    do {                                                         /* do while loop to make sure user enter a date to update */           
        var newDateUpdate: any = prompt("Please enter the date of the new task (yyyy-mm-dd)"); /* variable used to task date  */

    } while (newDateUpdate == "");
    tableRef.rows[Number(taskUpdate) - 1].innerHTML = taskUpdate + ". " + newTaskUpdate.concat(" - ", newDateUpdate);  /*Update the selected item with the information entered */

}
/* Method to clear Task List */
function clearTaskList() {
    var tableRef: any;                                  /* variable used to store table ID  */
    tableRef = document.getElementById("myTaskList");  /* Getting the ID of the table storing the value in the variable  */
    tableRef.innerHTML = " ";  /* Clear the entire table  */
}

/*Method to complete a task */ 
function completeTask() {
    var tableRef: any;                              /* variable used to store table ID  */
    tableRef = document.getElementById("myTaskList"); /* Getting the ID of the table storing the value in the variable  */

    do {
        var taskUpdate: any = prompt("Please choose a task number to complete"); /* variable used to store task number  */

    } while (taskUpdate == "");
    var taskComplete = tableRef.rows[Number(taskUpdate) - 1].innerHTML;  /* Store the selected item in a variable  */
    tableRef.rows[Number(taskUpdate) - 1].innerHTML = taskComplete.strike();  /* Strikethrough to indicate task completed   */
}
