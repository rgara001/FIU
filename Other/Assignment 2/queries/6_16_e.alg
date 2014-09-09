allEmpl := (project eSSN (employee)) product (project  pNumber (projects));
emplNotOnAll := allEmpl difference (project eSSN, pNumber (worksOn));
resSSN := (project eSSN (employee)) difference (project eSSN (emplNotOnAll));
res := project fName, mInit, lName (employee njoin resSSN);