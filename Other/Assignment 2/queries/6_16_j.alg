depMgr (mgrSSN)  := project mgrSSN (department);
depen (eSSN)   := project eSSN (dependent);
joinDepenMgr   := depMgr njoin depen;
mgrWithDep (mgrSSN)   :=  project mgrSSN (select (mgrSSN = eSSN) (joinDepenMgr));
mgrWithoutDep (mgrSSN)   := depMgr difference mgrWithDep;
res   := project fName, mInit, lName (select (mgrSSN = eSSN) (mgrWithoutDep njoin employee));
