namespace Postgrest.Connection

[<AutoOpen>]
module Connection =
    type PostgrestConnection = {
        Url: string
        Headers: Map<string, string>
    }
    
    type PostgrestConnectionBuilder() =
        // member _.Zero _ =
        //     {   Url = ""
        //         Headers = Map [] }
        
        member _.Yield _ =
            {   Url = ""
                Headers = Map [] }
       
        [<CustomOperation("url")>]
        member _.Url(connection, url) =
            { connection with Url = url }
        
        [<CustomOperation("headers")>]
        member _.Headers(connection, headers) =
            { connection with Headers = headers }
            
    let postgrestConnection = PostgrestConnectionBuilder()