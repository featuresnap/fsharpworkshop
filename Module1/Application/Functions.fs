module Functions

open Types

let tryPromoteToVip (customer,spendings) =
    if spendings > 100m then {customer with IsVip = true}
    else customer
