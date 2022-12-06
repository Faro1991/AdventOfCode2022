namespace AdventOfCode2022.FSharpHelpers

type signalFinder() = 
    class
        static member findSignal (input : string, markerLength: int) = 
            let result =input |> Seq.indexed |> Seq.findIndex (fun i ->
                let currentPos = fst i
                let uniqueChars = input.[currentPos..currentPos + (markerLength - 1)] |> Seq.distinct |> Seq.length = markerLength
                uniqueChars
            )
            result + markerLength
    end