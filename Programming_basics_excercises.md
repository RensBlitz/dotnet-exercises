# Day 1: Programming Basics – Exercise Overview

## 1️⃣ Variables & Primitive Data Types

| # | Title                  | Story & Goal                                                                 | Focus                           |
|---|------------------------|-----------------------------------------------------------------------------|---------------------------------|
| 1 | Pocket-Money Tracker   | Jana gets €5 on Monday and €3 on Wednesday. Store both amounts, then output the total. | integer & simple arithmetic     |
| 2 | Cafe Tip-Jar           | A bill is €18, tip is 12 %. Compute the final amount.                        | decimals & percentage           |
| 3 | Moon-Weight Converter  | A person's Earth weight is given. Calculate their weight on the Moon (16.5 % of Earth). | floating-point multiplication   |
| 4 | Book-Page Estimator    | Reading speed (pages/hour) × planned minutes of reading → pages that can be read today. | integer vs float casting        |
| 5 | Temperature Spread     | Given yesterday's high and low, output the difference and the average.       | mixed ints & floats             |
| 6 | Space Probe Signal-Time| Light takes ~299 792 km/s. For a probe 384 400 km away (the Moon), compute signal round-trip time. | larger numeric literals & precision |
| 7 | Fantasy-Potion Mix     | An alchemist mixes 30 % dragon blood, 50 % unicorn tears, 20 % stardust into a 750 ml vial. Print millilitres of each ingredient. | percentages → absolute volumes  |

---

## 2️⃣ Control Flow (If/Else, Switch, Loops)

| # | Title                  | Story & Goal                                                                 | Focus                           |
|---|------------------------|-----------------------------------------------------------------------------|---------------------------------|
| 1 | Even-Odd Game          | Ask for a number; print "wizard" if even, "orc" if odd.                      | basic if/else                   |
| 2 | Amusement-Park Ticket  | Under 12 or over 65 ride free, others pay. Output price.                     | multiple conditions             |
| 3 | Plant-Watering Schedule| For a given day name, print "water" only on Mon/Thu/Sat.                     | switch (or chained ifs)         |
| 4 | Fizz-Buzz-Lite         | Loop 1-20. "Fizz" for multiples of 3, number otherwise.                      | loop + modulo                   |
| 5 | Elevator Panel         | While user keeps entering floors, reject anything < 0 or > 20. Exit on "q".  | loop + validation               |
| 6 | Rain-Streak Counter    | Given a week's "rain/no-rain" list, print the longest consecutive rain stretch. | loop inside loop                |
| 7 | Simple Dungeon Crawler | Player starts with 10 health. A loop reads "hit", "potion", or "exit", adjusting health and ending when health ≤ 0 or exit. | sentinel loops + branching      |

---

## 3️⃣ Methods / Functions (Re-usable Logic)

| # | Title                  | Story & Goal                                                                 | Focus                           |
|---|------------------------|-----------------------------------------------------------------------------|---------------------------------|
| 1 | Hello Hero             | Write greet(name) returning "Welcome, [name]!".                              | parameter & return              |
| 2 | VAT Calculator         | addVat(netAmount, rate) returns gross amount.                                | multiple params                 |
| 3 | Pizza-Planner          | pizzasNeeded(people, slicesPerPerson) – a pizza has 8 slices.                | math & ceiling division         |
| 4 | Speed-Unit Switcher    | kmhToMps(kmh) and mpsToKmh(mps) reciprocal converters.                       | two related functions           |
| 5 | Grade-Average          | average(int[] scores) returns double. Ignore empty array with -1.            | array param                     |
| 6 | Bank-Fee Simulator     | applyMonthlyFee(balance, feePercent, minFee) returns new balance, picking the greater of percent or minimum fee. | branches inside function        |
| 7 | Tiny-Encryption        | shiftCipher(text, offset) – basic Caesar cipher shifting letters, preserving case. | loops + char maths              |

---

## 4️⃣ Collections (Arrays, Lists, Maps)

| # | Title                  | Story & Goal                                                                 | Focus                           |
|---|------------------------|-----------------------------------------------------------------------------|---------------------------------|
| 1 | Shopping-Basket        | Store 5 items in a list; print them comma-separated.                         | list basics                     |
| 2 | Classroom Scores       | Given 10 scores, compute min, max, and average.                              | array traversal                 |
| 3 | Bus-Seats              | A boolean array of 40 seats; mark 3 random as occupied, print first free seat index. | arrays + search                 |
| 4 | Library Catalogue      | Map ISBN → title; add, look up, and remove one book.                         | map/dictionary                  |
| 5 | Vowel-Counter          | For every vowel, store its count in a map from a supplied sentence.          | map update inside loop          |
| 6 | Cinema Row Rearrange   | Given a list of viewer ages, move all under-18s to the front while preserving order. | list filtering & stable partition |
| 7 | Leaderboard            | List of (name, points) tuples; sort descending, output top 3 with ranks (handling ties). | composite data + custom sort    |

---

## 5️⃣ Classes & Objects (Basic OOP)

| # | Title                  | Story & Goal                                                                 | Focus                           |
|---|------------------------|-----------------------------------------------------------------------------|---------------------------------|
| 1 | Simple Car             | Class with make, model, year; method description() returns a string.          | attributes & to-string          |
| 2 | Bank Account           | Fields: owner, balance. Methods: deposit, withdraw. Prevent overdraft.        | state change                    |
| 3 | Pet Diary              | Class Pet (name, type, age). Method speak() returns type-specific sound string. | basic polymorphism hint         |
| 4 | Todo Item              | Class with title, dueDate, completed flag. Add toggleCompleted() and isOverdue(now). | booleans + dates                |
| 5 | Weather Sensor         | Class records hourly temps into an internal list; method averageTemp().       | combining object + collection   |
| 6 | Online Course          | Class Course has title and a list of enrolled Student objects. Add methods enrol() and drop(), keep count. | object-to-object relations      |
| 7 | Mini-RPG Combat        | Classes Hero and Monster each with health, attack power. Implement attack(target) reducing target health, plus a battle() loop until one faints. | multiple objects interacting    |

