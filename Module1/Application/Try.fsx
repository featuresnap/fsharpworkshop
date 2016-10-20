#load "Types.fs"
#load "Functions.fs"

open Types
open Functions

let x = 1

let customer1 = {Id=1; IsVip=false; Credit=10m}
let customer2 = {Id=2; IsVip=false; Credit=0m}

let vipCustomer1 = tryPromoteToVip(customer1, 101m)
let vipCustomer2 = tryPromoteToVip(customer2, 99m)