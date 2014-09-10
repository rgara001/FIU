resEmp   :=  select (fName = dependentName) (employee njoin dependent);
res            := project fName, mInit, lName (resEmp);