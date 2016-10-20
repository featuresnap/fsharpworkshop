module Types

open System

type PersonalDetails = {
    FirstName:string;
    LastName:string;
    DateOfBirth:DateTime
}

type Notifications = 
    |NoNotifications
    |ReceiveNotifications of receiveDeals:bool * receiveAlerts:bool

[<Measure>] type AUD
[<Measure>] type USD

type Customer = { 
    Id: int
    IsVip: bool
    Credit: decimal<USD>
    PersonalDetails: PersonalDetails option
    Notifications: Notifications
}