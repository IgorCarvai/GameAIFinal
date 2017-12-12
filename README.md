﻿# GameAIFinal

Collaboration with:
Igor Carvalho 
Daniel Hendricks
Jeremy Torella

This project uses an MDP algorithm to place towers in a tower-defense-like game. The states are defined as all monster locations, all tower locations, remaining health, and coins. Action include what type of tower and where to place it. The uncertainty in the resulting state after an action is based on the uncertain movements of the monsters.

We limited tower placement to 24 locations to simplify the algorithm so it may run faster. We also limited the MDP to only seek one action forward to save time as well. 

Q) What was your biggest success of this project?

A) Our proudest accomplishment would be that we have an AI that successfully defends itself against minions that move sudo-randomly. 

