Get Storyboards Test
====================
tags: Storyboard


Number of storyboards for user should be returned
-------------------------------------------------

tags: Smoke, Api

* Enter user "userA" with "10" storyboards
* Fetch number of storyboards for "userA"
* The number of storyboards should be "10" 


Test
----

tags: Sanity, Api

* Enter user "userB" with "10" storyboards
* Fetch number of storyboards for "userC"
* The number of storyboards should not be "10" 
