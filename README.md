# Unity2d-GroundCheck
Ground check script utilizing unity5 IsTouchingLayers feature

Special for [unity2d](http://www.reddit.com/r/Unity2D/) subredit [Weekly Challenge #4 - Ground Detect]( http://www.reddit.com/r/Unity2D/comments/3752yr/weekly_challenge_4_ground_detect/)


![ground check player](http://storage4.static.itmages.ru/i/15/0525/h_1432542105_8352942_bbd8f303f4.png)

This script use [IsTouchingLayers](http://docs.unity3d.com/ScriptReference/Collider2D.IsTouchingLayers.html) feature, appeared at Unity5
I've used sepearated collider to check whether object grounded or not, and another collider for player bounds.

![plaer colliders](http://storage2.static.itmages.ru/i/15/0525/h_1432541007_6848111_50251b75f1.png)

* **rectangle** - player bounds
* **circle ** - ground check collider


As usual you need to create separated layer for ground colliders. otherwise you can rewrite the script and omit ground LayerMask
