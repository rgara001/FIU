emplDep5	:= select (dNumber = 5) (employee);
productXnum 	:= project pNumber (select (pName = 'ProductX') (projects));
xProjects	:= worksOn njoin productXnum;
resXProjects	:= project eSSN (select (wHours > 10) (xProjects));
res	:= project fName, mInit, lName (emplDep5 njoin resXProjects);