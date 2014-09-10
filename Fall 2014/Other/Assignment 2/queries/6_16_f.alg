worksOnSSN	:= employee njoin (project eSSN (worksOn));
res	:= project fName, mInit, lName (employee difference worksOnSSN);