// Creating Singleton
// Only one instance of this class can be created
class CloudCodeExecutor {
    // Declare class instance property
    static let sharedInstance = CloudCodeExecutor()

    // Declare an initializer
    // Because this class is singleton only one instance of this class can be created
    init() {
        print("CloudCodeExecutor has been initialized")
    }
    // Add a function
    func processCloudCodeOperation() {
        print("Started processing cloud code operation")
        // Your other code here
    }
}
// Call function of Singleton class
CloudCodeExecutor.sharedInstance.processCloudCodeOperation()
// Call cloud code operation function again
CloudCodeExecutor.sharedInstance.processCloudCodeOperation()
// And again to see that class initializer was called only once
CloudCodeExecutor.sharedInstance.processCloudCodeOperation()