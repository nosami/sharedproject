namespace iosapp

open System
open SharedProject
open UIKit
open Foundation

[<Register ("AppDelegate")>]
type AppDelegate () =
    inherit UIApplicationDelegate ()
    let x = mymodule.thing
    override val Window = null with get, set

    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching (app, options) =
        true
