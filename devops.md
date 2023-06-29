# DevOps Interview Questions

<details>
 <summary>1.What are the popular DevOps tools that you use?</summary>
  <p>We use folowing tools for work inDevOps:</p>
    <ol>
        <li>Jenkins : This is an open source automation server used as a continuous integration tool. We can build,deployand runautomated tests withJenkins.</li>
        <li>GIT:It is a version controltool used for tracking changesin files and software.</li>
        <li>Docker : This is a popular tool for containerization of services. It is very useful in Cloud based deployments.</li>
        <li>Nagios :We use Nagiosfor monitoring ofITinfrastructure.</li>
        <li>Splunk :Thisis a powerfultoolfor log search as wel as monitoring production systems.</li>
        <li>Puppet :We use Puppet to automate our DevOps work so that it isreusable.</lI>
    </ol>
</details>

<details>
 <summary>2.What are the main benefits of DevOps?</summary>
  <p>DevOpsis a very popular trend inSoftware Development. Some ofthe main benefits ofDevOps are asfolows:</p>
    <ol>
        <li> <b>Release Velocity</b> : DevOps practices help in increasing the release velocity. We can release code to productionmore oftenand withmore confidence.</li>
        <li><b>Development Cycle</b> : With DevOps, the complete Development cycle from initial design to production deployment becomesshorter</li>
        <li><b>Deployment Rollback</b> : In DevOps, we plan for any failure in deployment rolback due to a bug in code or 
issue in production. This gives confidence in releasing feature without worrying about downtime for rolback.
</li>
        <li><b>Defect Detection</b>: With DevOps approach, we can catch defects much earlier than releasing to production It improvesthe quality ofthe software</li>
        <li><b>Recovery fromFailure</b> :In case of a failure, we can recover very fast withDevOps process.</li>
        <li><b>Collaboration</b>:WithDevOps, colaboration between development and operations professionalsincreases.</lI>
         <li><b>Performance-oriented</b> : With DevOps, organization folows performance-oriented culture in which teams become more productive andmore innovative.</lI>
    </ol>
</details>

<details>
 <summary>3.What is the typical DevOps workflow you use in your organization?</summary>
  <p>The typicalDevOps workflowin our organization is as folows:</p>
    <ol>
        <li>We use Atlassian Jira for writing requirements and tracking tasks.</li>
        <li>Based on the Jira tasks, developers checkin code into GIT version control system.</li>
        <li>The code checked into GITis built by usingApache Maven.</li>
        <li>The build processis automated with Jenkins.</li>
        <li>Code built onJenkins is sent to organization’s Artifactory.</li>
        <li>Jenkins automaticaly picks the libraries from Artifactory and deploys it to Production</li>
        <li>During Production deployment Docker images are used to deploy same code on multiple hosts.</li>
        <li>Once code is deployed to Production, we use Nagiosto monitor the health of production servers.</lI>
        <li>Splunk based alertsinformus of any issues or exceptionsin production.</li>
    </ol>
</details>



<details>
 <summary>3.What is the typical DevOps workflow you use in your organization?</summary>
  <p>The typicalDevOps workflowin our organization is as folows:</p>
    <ol>
        <li>We use Atlassian Jira for writing requirements and tracking tasks.</li>
        <li>Based on the Jira tasks, developers checkin code into GIT version control system.</li>
        <li>The code checked into GITis built by usingApache Maven.</li>
        <li>The build processis automated with Jenkins.</li>
        <li>Code built onJenkins is sent to organization’s Artifactory.</li>
        <li>Jenkins automaticaly picks the libraries from Artifactory and deploys it to Production</li>
        <li>During Production deployment Docker images are used to deploy same code on multiple hosts.</li>
        <li>Once code is deployed to Production, we use Nagiosto monitor the health of production servers.</lI>
        <li>Splunk based alertsinformus of any issues or exceptionsin production.</li>
    </ol>
</details>

<details>
 <summary>4.How do you take DevOps approach with Amazon Web Services?</summary>
  <p>Amazon Web Services (AWS) provide many tools and features to deploy and manage applications inAWS. As per DevOps, we treat infrastructure as code. We mainly use folowing two servicesfromAWS for DevOps:</p>
    <ol>
        <li><b>CloudFormation</b> : We use AWS CloudFormation to create and deploy AWS resources by using templates. We can describe our dependencies and pass special parameters in these templates.  CloudFormation can read these templates and deploy the application and resourcesinAWS cloud.</li>
        <li><b>OpsWorks </b>: AWS provides another service caled OpsWorks that is used for configuration management by utilizing Chef framework. We can automate server configuration, deployment and management by using OpsWorks. It helpsinmanaging EC2 instancesinAWS as wel as any on-premisesservers.</li>
    </ol>
</details>

<details>
 <summary>5.How will you run a script automatically when a developer commits a change into GIT?</summary>
  <p>GITprovidesthe feature to execute customscripts when certain event occursinGIT. This feature is caled hooks.</p>
  <p>We canwrite two types of hooks.</p>
    <ol>
        <li>Client-side hooks</li>
        <li>Server-side hooks</li>
    </ol>
    <p>For this case, we can write a Client-side post-commit hook. This hook wil execute a customscript inwhich we can add the message and code thatwewantto runautomaticalywitheachcommit.</p>
</details>

<details>
 <summary>6.What are the main features of AWS OpsWorks Stacks?</summary>
  <p>Some ofthe main features ofAWS OpsWorks Stacks are asfolows:</p>
    <ol>
        <li>Server Suppo rt:AWS OpsWorks Stacks we can automate operational tasks on any server inAWS as wel as our own data center.</li>
        <li>Scalable Automation : We get automated scaling support with AWS OpsWorks Stacks. Each new instance in AWS can read configuration fromOpsWorks. It can even respond to systemevents in same way as other instances do. </li>
        <li>The code checked into GITis built by usingApache Maven.</li>
        <li>The build processis automated with Jenkins.</li>
        <li>Code built onJenkins is sent to organization’s Artifactory.</li>
        <li>Jenkins automaticaly picks the libraries from Artifactory and deploys it to Production</li>
        <li>During Production deployment Docker images are used to deploy same code on multiple hosts.</li>
        <li>Once code is deployed to Production, we use Nagiosto monitor the health of production servers.</lI>
        <li>Splunk based alertsinformus of any issues or exceptionsin production.</li>
    </ol>
</details>

<details>
 <summary>7.How does CloudFormation work in AWS?</summary>
  <p>AWS CloudFormation is used for deploying AWS resources.</p>
  <p>In CloudFormation, we have to first create a template for a resource. A template is a simple text file that contains information about a stack on AWS. A stack is a collection of AWS resourced that we want to deploy together in an AWS as a group</p>
  <p> Once the template is ready and submitted to AWS, CloudFormation wil create al the resources in the template. This helps in automationofbuildingnewenvironmentsinAWS</p>
</details>

<details>
 <summary>8.What is CICD in DevOps?</summary>
  <p>CICD stands for Continuous Integration and Continuous Delivery. These are two different concepts that are complementary to each other.</p>
  <p><b>Continuous Integration (CI)</b> : In CI al the developer work is merged to main branch several times a day. This helps in reducing integration problems</p>
  <p>In CI we try to minimize the duration for which a branch remains checked out. A developer gets early feedback on the new code added to main repository by using CI.</p>   
  <p><b>Continuous Delivery (CD) </b>: In CD, a software team plans to deliver software in short cycles. They perform development,testing and release in such a short time that incremental changes can be easily delivered to production</p>
  <p>In CD, as a DevOps we create a repeatable deployment process that can help achieve the objective of Continuous Delivery.</p>

</details>

<details>
 <summary>3.What is the typical DevOps workflow you use in your organization?</summary>
  <p>The typicalDevOps workflowin our organization is as folows:</p>
    <ol>
        <li>We use Atlassian Jira for writing requirements and tracking tasks.</li>
        <li>Based on the Jira tasks, developers checkin code into GIT version control system.</li>
        <li>The code checked into GITis built by usingApache Maven.</li>
        <li>The build processis automated with Jenkins.</li>
        <li>Code built onJenkins is sent to organization’s Artifactory.</li>
        <li>Jenkins automaticaly picks the libraries from Artifactory and deploys it to Production</li>
        <li>During Production deployment Docker images are used to deploy same code on multiple hosts.</li>
        <li>Once code is deployed to Production, we use Nagiosto monitor the health of production servers.</lI>
        <li>Splunk based alertsinformus of any issues or exceptionsin production.</li>
    </ol>
</details>

