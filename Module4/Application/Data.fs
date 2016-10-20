module Data
open Types
open FSharp.Data

type Json = JsonProvider<"Data.json">

let getSpendings id = 
    Json.Load "Data.json"
    |> Seq.filter (fun c -> c.Id = id)
    |> Seq.collect (fun c -> c.Spendings)
    |> List.ofSeq