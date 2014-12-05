CircularSearch
==============

CircularSearch is a utility to add, maintain and search the Circulars orders which are issue in organizations

This Utility was created by me for use by my father. He is a working professional who have to handle the Inter Organization circulars (Information notices)ba lot ranging till 8-10 years, which are hundreds in no if not thousands. 

This utility has 3 parts:

1. Display a table with all the circular titles (not file title but actualy text title of the circular), circular number and date.bThere is a search functionality to search in the titles column for particular keywords.

2. Manually add new circulars in the list. Which is a form to fill all the entries and insert new circular information.

3. Automatically add circulars: (This is a most error prone part) User indicate the folder which contains multiple new circulars. This folder is traversed and all the PDFs are read, parsed usinf PDF parser and relevent information is fetched from the pdf and inserted to the database. (This parsing is only relevent to the format used by the spacific organization as it relies on the structure of the file to fetch information, there is no intelligent algorithm to detech the data. just a split based on couple of markers)

(NOTE: This was created in a very short time and for particular use, so there is no guarantee of working and also code can be much more efficient then this, if time permits. If in anycase you want to use this code, feel free to take reference and use).

   
