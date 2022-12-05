namespace AdventOfCode2022.FSharpHelpers

type scoreCalculator () =
    class
    let pointsMatch (item: string) = 
        let result = match item with
                        | "X" | "A" -> 1
                        | "Y" | "B" -> 2
                        | "Z" | "C" -> 3
                        | _ -> 0
        result

    member this.total (input : System.Collections.Generic.List<string>) = List.ofSeq(input) |> List.sumBy( fun (x: string) ->
            let result =
                let ownChoice = string (x.Split(" ").[1])
                let roundScore = x.Split(" ") |> ( fun y ->
                        pointsMatch (y.[1]) - pointsMatch (y.[0])
                    )
                let roundPoints = match roundScore with
                                    | 1 | -2 -> 6
                                    | -1 | 2 -> 0
                                    | 0 -> 3
                                    | _ -> 0
                pointsMatch (ownChoice) + roundPoints
            result
        )
    
    member this.optimalScore (input : System.Collections.Generic.List<string>) = List.ofSeq(input) |> List.sumBy( fun (x: string) ->
            let result =
                let neededResult = string (x.Split(" ").[1])
                let opponentChoice = string (x.Split(" ").[0])
                let pointsChoice = match neededResult with
                                    | "X" -> match opponentChoice with
                                                | "A" -> "Z"
                                                | "B" -> "X"
                                                | "C" -> "Y"
                                                | _ -> "E"
                                    | "Y" -> opponentChoice
                                    | "Z" -> match opponentChoice with
                                                | "A" -> "Y"
                                                | "B" -> "Z"
                                                | "C" -> "X"
                                                | _ -> "E"
                                    | _ -> "E"
                                    |> pointsMatch
                let roundPoints = match neededResult with
                                    | "X" -> 0
                                    | "Y" -> 3
                                    | "Z" -> 6
                                    | _ -> -1
                pointsChoice + roundPoints
            result
        )
    end