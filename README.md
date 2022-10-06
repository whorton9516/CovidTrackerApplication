# CovidTrackerApplication

Development Recap:

This portion of the coding assessment was pretty difficult for me due some various factors.
The first factor being that I don't have much experience with API consumption and http requests.
This set me back on the front end because it required me to send a lot of time researching.

The second were some external factors that pulled my away during the evenings when I got off work.
Given a more structured environment with dedicated time, I'm confident that I could performed much better than I did

---------------------------------------------------------------------------------------------------------

Initially I struggled to find the correct project template to build off of.
The first template I chose was a basic ASP.NET MVC project. With little experience in hombrewing a
ui, I decided to scrap that project and start over.

I sampled a few telerik templates and after a few trials, I decided to stick with the Telerik ASP.NET MVC template.
This template had the most support and tutorials online (that I could find).

---------------------------------------------------------------------------------------------------------

My first task was to get the data from the API into my project. After a little research and a few different approaches,
I was able to get the data into the project and saved into a List<> with no errors or warnings.

---------------------------------------------------------------------------------------------------------

My next task was to populate that data into a table. This came with relative ease compared to some of the other tasks.
I did this by using the List<> as a parameter when loading the main View. I saved the data in the @model
attribute and then made calls to that data with simple html code.

---------------------------------------------------------------------------------------------------------

After this, I worked on implementing the required functionality of the grid. This is where the project came to a halt.
I was unable to find a way to add this functionality while maintaing the data. KendoUi has a different method of getting
data than the one I had already implemented. I was unable to find a way to make these two approaches cooperate despite
trying many different approaches to this issue. Given more time and a team to work with, I am confident that I would
have been able to accomplish this task.







What did I learn?
-----------------
1. How to make calls to an Api
	a. Api Consumption
2. Different Ui libraries for ASP.NET
3. HTML
	a. I have learned HTML but this was the most in depth I've gotten (despite my written html not being very complex)
4. JavaScript
	a. I have also learned JavaScript but this was more in depth as well