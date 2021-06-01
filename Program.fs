﻿module AppTests

open Expecto

open NewAppBasic.Counter

let avaloniaTests = 
    testList "NewAppBasic" [
        test "[conv] string -> list string" {
            let someResult = splitIntoList "abc"
            Expect.equal someResult ['a'; 'b'; 'c'] "Result is a list of char"
        }

        test "[conv] list string -> string with spaces" {
            let someResult = createWordFromList ['a'; 'b'; 'c']
            Expect.equal someResult "a b c" "Result is a list of char"
        }

        test "[length] list -> int" {
            let someResult = getLengthFromList ['a'; 'b'; 'c']
            Expect.equal someResult 3 "Number of items in the list."
        }
    ]


[<EntryPoint>]
let main argv =
    runTestsWithArgs defaultConfig argv avaloniaTests