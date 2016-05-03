# sampleServiceClient
itc172 classwork


Class Notes: 
- Have the service running in a separate instance of visual studio (this is a work-around since we don't have iis)
- Copy the localhost address from the window where the service is running. 
- In your empty website, add a service reference > paste the address you copied > click go. //This tells the client what services are available for it to use. 
- Add > Web Form (ours was just named default). Add a dropdown list, gridview, and button. Remember to re-name them. 
- In the code: 
-   (serviceRefName).(serviceRefNameClient) sc = new (serviceRefName).(serviceRefNameClient)  // new service reference object. 
-   You can then use the service ref client object to access/link to the methods (see fill_author_dropdown), and the service ref itself to get public classes from the service (see submitbutton_click). 
- If you double click the button in default.aspx's design view, it will add a click event listener to the button, and take you to the code to handle that event. 

