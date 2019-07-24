// function MoveSidebarNav()
// {
//   var sidebar = document.getElementById('sidebar');
//     var mainContent = document.getElementById('main-content');
//     if(sidebar.classList.contains('active'))
//     {
//       document.getElementById('main-content').className = "expanded";
//     }
//     document.getElementById('sidenavbar-postion').onclick = function() {
//         sidebar.classList.toggle('active');
//         mainContent.classList.toggle('expanded');
//     };
// }

// function SearchBarEnter()
// {
//   var input = document.getElementById("SearchBar");

//   input.addEventListener("keyup", function(event) {
//     if(event.keyCode === 13)
//     {
//       event.preventDefault();
//       console.log(input.value);
//       console.log("Enter has been pressed.");
//     }
//   })
// }

function Autoccomplete(element, array)
{
  console.log(array)
  var currentFocus;

  element.addEventListener("input", function(e) {
    var a, b, i, val = this.value;
    closePreviousLists();

    if (!val) { return false;}
      currentFocus = -1;
      /*create a DIV element that will contain the items (values):*/
      a = document.createElement("DIV");
      a.setAttribute("id", this.id + "autocomplete-list");
      a.setAttribute("class", "autocomplete-items");
      /*append the DIV element as a child of the autocomplete container:*/
      this.parentNode.appendChild(a);
      /*for each item in the array...*/
      for (i = 0; i < array.length; i++) {
        /*check if the item starts with the same letters as the text field value:*/
        if (array[i].substr(0, val.length).toUpperCase() == val.toUpperCase()) {
          /*create a DIV element for each matching element:*/
          b = document.createElement("DIV");
          /*make the matching letters bold:*/
          b.innerHTML = "<strong>" + array[i].substr(0, val.length) + "</strong>";
          b.innerHTML += array[i].substr(val.length);
          /*insert a input field that will hold the current array item's value:*/
          b.innerHTML += "<input type='hidden' value='" + array[i] + "'>";
          /*execute a function when someone clicks on the item value (DIV element):*/
          b.addEventListener("click", function(e) {
              /*insert the value for the autocomplete text field:*/
              element.value = this.getElementsByTagName("input")[0].value;
              /*close the list of autocompleted values,
              (or any other open lists of autocompleted values:*/
                closePreviousLists();
          });
          a.appendChild(b);
        }
      }
  });
  /*execute a function presses a key on the keyboard:*/
  element.addEventListener("keydown", function(e) {
      var x = document.getElementById(this.id + "autocomplete-list");
      if (x) x = x.getElementsByTagName("div");
      if (e.keyCode == 40) {
        /*If the arrow DOWN key is pressed,
        increase the currentFocus variable:*/
        currentFocus++;
        /*and and make the current item more visible:*/
        addActive(x);
      } else if (e.keyCode == 38) { //up
        /*If the arrow UP key is pressed,
        decrease the currentFocus variable:*/
        currentFocus--;
        /*and and make the current item more visible:*/
        addActive(x);
      } else if (e.keyCode == 13) {
        /*If the ENTER key is pressed, prevent the form from being submitted,*/
        e.preventDefault();
        if (currentFocus > -1) {
          /*and simulate a click on the "active" item:*/
          if (x) x[currentFocus].click();
        }
      }
  });


  function addActive(x)
  {
    if(!x) {
      return false;
    }

    removeActive(x);
    if (currentFocus >= x.length) currentFocus = 0;
    if (currentFocus < 0) currentFocus = (x.length - 1);

    x[currentFocus].classList.add("autocomplete-active");
  }


  function removeActive(x) {
    /*a function to remove the "active" class from all autocomplete items:*/
    for (var i = 0; i < x.length; i++) {
      x[i].classList.remove("autocomplete-active");
    }
  }

  // Closes all lists except the current one
  function closePreviousLists(element1) {
    var lists = document.getElementsByClassName("autocomplete-items");

    for(var i = 0; i < lists.length; i++)
    {
      if(element1 != lists[i] && element1 != element) {
        lists[i].parentNode.removeChild(lists[i]);
      }
    }
  }

  document.addEventListener("click", function(e) {
    closePreviousLists(e.target);
  });
}


