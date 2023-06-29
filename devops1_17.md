# DevOps Interview Questions

<details>
 <summary>1.What are the popular DevOps tools that you use?</summary>
  <p>We use following tools for work in DevOps:</p>
    <ol>
        <li>Jenkins : This is an open source automation server used as a continuous integration tool. We can build,deploy and run automated tests with Jenkins.</li>
        <li>GIT:It is a version control tool used for tracking changes in files and software.</li>
        <li>Docker : This is a popular tool for containerization of services. It is very useful in Cloud based deployments.</li>
        <li>Nagios :We use Nagios for monitoring of IT infrastructure.</li>
        <li>Splunk :This is a powerful tool for log search as wel as monitoring production systems.</li>
        <li>Puppet :We use Puppet to automate our DevOps work so that it is reusable.</lI>
    </ol>
</details>

<details>
 <summary>2.What are the main benefits of DevOps?</summary>
  <p>DevOps is a very popular trend in Software Development. Some ofthe main benefits of DevOps are as follows:</p>
    <ol>
        <li> <b>Release Velocity</b> : DevOps practices help in increasing the release velocity. We can release code to production more often and with more confidence.</li>
        <li><b>Development Cycle</b> : With DevOps, the complete Development cycle from initial design to production deployment becomes shorter</li>
        <li><b>Deployment Rollback</b> : In DevOps, we plan for any failure in deployment rolback due to a bug in code or issue in production. This gives confidence in releasing feature without worrying about downtime for rolback.</li>
        <li><b>Defect Detection</b>: With DevOps approach, we can catch defects much earlier than releasing to production It improvesthe quality of the software</li>
        <li><b>Recovery from Failure</b> :In case of a failure, we can recover very fast with DevOps process.</li>
        <li><b>Collaboration</b>:With DevOps, colaboration between development and operations professionals increases.</lI>
         <li><b>Performance-oriented</b> : With DevOps, organization folows performance-oriented culture in which teams become more productive and more innovative.</lI>
    </ol>
</details>

<details>
 <summary>3.What is the typical DevOps workflow you use in your organization?</summary>
  <p>The typical DevOps workflow in our organization is as follows:</p>
    <ol>
        <li>We use Atlassian Jira for writing requirements and tracking tasks.</li>
        <li>Based on the Jira tasks, developers check in code into GIT version control system.</li>
        <li>The code checked into GIT is built by using Apache Maven.</li>
        <li>The build processis automated with Jenkins.</li>
        <li>Code built on Jenkins is sent to organization’s Artifactory.</li>
        <li>Jenkins automaticaly picks the libraries from Artifactory and deploys it to Production</li>
        <li>During Production deployment Docker images are used to deploy same code on multiple hosts.</li>
        <li>Once code is deployed to Production, we use Nagios to monitor the health of production servers.</lI>
        <li>Splunk based alerts inform us of any issues or exceptions in production.</li>
    </ol>
</details>


<details>
 <summary>4.How do you take DevOps approach with Amazon Web Services?</summary>
  <p>Amazon Web Services (AWS) provide many tools and features to deploy and manage applications in AWS. As per DevOps, we treat infrastructure as code. We mainly use folowing two services from AWS for DevOps:</p>
    <ol>
        <li><b>CloudFormation</b> : We use AWS CloudFormation to create and deploy AWS resources by using templates. We can describe our dependencies and pass special parameters in these templates.  CloudFormation can read these templates and deploy the application and resources in AWS cloud.</li>
        <li><b>OpsWorks </b>: AWS provides another service called OpsWorks that is used for configuration management by utilizing Chef framework. We can automate server configuration, deployment and management by using OpsWorks. It helps in managing EC2 instances in AWS as wel as any on-premises servers.</li>
    </ol>
</details>

<details>
 <summary>5.How will you run a script automatically when a developer commits a change into GIT?</summary>
  <p>GIT provides the feature to execute custom scripts when certain event occurs in GIT. This feature is caled hooks.</p>
  <p>We can write two types of hooks.</p>
    <ol>
        <li>Client-side hooks</li>
        <li>Server-side hooks</li>
    </ol>
    <p>For this case, we can write a Client-side post-commit hook. This hook wil execute a custom script inwhich we can add the message and code that we want to run automaticaly with each commit.</p>
</details>

<details>
 <summary>6.What are the main features of AWS OpsWorks Stacks?</summary>
  <p>Some of the main features of AWS OpsWorks Stacks are as follows:</p>
    <ol>
        <li>Server Support:AWS OpsWorks Stacks we can automate operational tasks on any server in AWS as well as our own data center.</li>
        <li>Scalable Automation : We get automated scaling support with AWS OpsWorks Stacks. Each new instance in AWS can read configuration from OpsWorks. It can even respond to system events in same way as other instances do. </li>
        <li>The code checked into GIT is built by using Apache Maven.</li>
        <li>The build processis automated with Jenkins.</li>
        <li>Code built on Jenkins is sent to organization’s Artifactory.</li>
        <li>Jenkins automaticaly picks the libraries from Artifactory and deploys it to Production</li>
        <li>During Production deployment Docker images are used to deploy same code on multiple hosts.</li>
        <li>Once code is deployed to Production, we use Nagios to monitor the health of production servers.</lI>
        <li>Splunk based alerts informus of any issues or exceptions in production.</li>
    </ol>
</details>

<details>
 <summary>7.How does CloudFormation work in AWS?</summary>
  <p>AWS CloudFormation is used for deploying AWS resources.</p>
  <p>In CloudFormation, we have to first create a template for a resource. A template is a simple text file that contains information about a stack on AWS. A stack is a collection of AWS resourced that we want to deploy together in an AWS as a group</p>
  <p> Once the template is ready and submitted to AWS, CloudFormation wil create al the resources in the template. This helps in automation of building new environments in AWS</p>
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
 <summary>9.What are the best practices of Continuous Integration (CI)?</summary>
  <p>Some of the best practices of Continuous Integration (CI) are as follows:</p>
    <ol>
        <li><b>Build Automation</b> : In CI, we create such a build environment that even with one command build can be triggered. This automation is done all the way up to deployment to Production environment.</li>
        <li><b>Main Code Repository</b> : In CI, we maintain a main branch in code repository that stores all the Production ready code. This is the branch that we can deploy to Production any time.</li>
        <li><b>Self-testing build</b> : Every build in CI should be self-tested. It means with every build there is a set of tests that runs to ensure that changes are of high quality.</li>
        <li> <b>Every day commits to baseline </b>: Developers will commit all of theirs changes to baseline every day. This ensures that there is no big pile up of code waiting for integration with the main repository for a long time.</li>
        <li><b>Build every commit to baseline</b> : With Automated Continuous Integration, every time a commit is made into baseline, a build is triggered. This helps in confirming that every change integrates correctly.</li>
        <li><b>Fast Build Process</b> : One of the requirements of CI is to keep the build process fast so that we can quickly identify any problem.</li>
        <li><b>Production like environment testing </b>:In CI, we maintain a production like environment also known as preproduction or staging environment, which is very close to Production  environment. We perform testing in this environment to check for any integration issues.</li>
        <li> <b>Publish Build Results</b> : We publish build results on a common site so that everyone can see these and take corrective actions.</lI>
        <li><b>Deployment Automation</b>:The deployment process is automated to the extent that in a build process we can add the step of deploying the code to a test environment. On this test environment all the stakeholders can access and test the latest deliver</li>
    </ol>
</details>

<details>
 <summary>10.What are the benefits of Continuous Integration (CI)?</summary>
  <p>The benefits of Continuous Integration (CI) are as follows:</p>
    <ol>
        <li>CI makes the current build constantly available for testing, demo and release purpose</li>
        <li>With CI, developers write modular code that works wel with frequent code check-ins</li>
        <li>Incase of a unit test failure or bug, developer can easily revert back to the bug-free state ofthe code</li>
        <li>There is drastic reduction in chaos on release day with CI practices.</li>
        <li>With CI, we can detect Integration issues much earlier in the process.</li>
        <li>Automated testing is one very useful sideefect of implementing CI.</li>
        <li>Al the stakeholders including business partners can see the smal changes deployed into pre-production environment. This provides early feedback on the changes to software.</li>
        <li>Automated CI and testing generates metrics like code-coverage, code complexity that help in improving the development process.</li>
    </ol>
</details>

<details>
 <summary>11.What are the options for security in Jenkins?</summary>
  <p>In Jenkins, it is very important to make the system secure by setting user authentication and authorization. To do this we have to do following:</p>
    <ol>
        <li>First we have to set up the Security Realm. We can integrate Jenkins with LDAP server to create user authentication.</li>
        <li>Second part is to set the authorization for users. This determines which user has access to what resources.</li> 
    </ol>
  <p>In Jenkins some of the options to setup security are as follows:</p>
    <ol>
        <li> We canuse Jenkins’ own User Database.</li>
        <li>We can use LDAP plugin to integrate Jenkins with LDAP server.</li>
        <li>We can also setup Matrix based security on Jenkins.</li>
    </ol>
</details>

<details>
 <summary>12. What are the main benefits of Chef?</summary>
  <p>Chef is an automation tool for keeping infrastructure as code. It has many benefits. Some of these are as follows:</p>
    <ol>
        <li>CloudDeployment:We can use Chef to perform automated deployment in Cloud environment.</li>
        <li>Multi-cloudsupport:With Chef we can even use multiple cloud providers for our infrastructure.</li>
        <li>HybridDeployment :Chef supports both Cloud based as well as data center-based infrastructure.</li>
        <li>High Availability : With Chef automation, we can create high availability environment. In case of hardware failure, Chef can maintain or start new servers in automated way to maintain highly available environment.</li>
    </ol>
</details>

<details>
 <summary>13. What is the architecture of Chef?</summary>
  <p>Chef is composed of many components like Chef Server, Client etc. Some of the main components in Chef are as follows:</p>
    <ol>
        <li>Client: These are the nodes or individual users that communicate with Chef server.</li>
        <li>ChefManage : This is the web console that is used for interacting with Chef Serve</li>
        <li>Load Balancer : All the Chef server API requests are routed through Load Balancer. It is implemented in Nginx</li>
        <li>Bookshelf: This i sthe component that stores cookbooks. All the cookbooks are stored in a repository. It is separate storage from the Chef server.</li>
        <li>PostgreSQL:This is the data repository for Chef server.</li>
        <li>Chef Server : This is the hub for configuration data. Al the cookbooks and policies are stored in it. It can scale to the size of any enterprise. </li>
    </ol>
</details>

<details>
 <summary>14. What is a Recipe in Chef?</summary>
    <p>In any organization, Recipe is the most fundamental configuration element. It is written in Ruby language. It is a collection of resources defined by using patterns.</p>
    <p>A Recipe isstored ina Cookbook and it may have dependency on other Recipe.</p>
    <p>We can tag Recipe to create some kind of grouping.</p>
    <p>We have to add a Recipe in run-list before using it by chef-client.</p>
    <p>It always maintains the execution order specified in run-list</p>
 </details>


<details>
 <summary> 15. What are the main benefits of Ansible?</summary>
  <p>Ansible is a powerful tool for IT Automation for large scale and complex deployments. It increases the productivity of team.</p>
  <p>Some of the main benefits of Ansible are as folows:</p>
    <ol>
        <li>Productivity :It helps in delivering and deploying with speed. It increases productivity in an organization.</li>
        <li>Automation : Ansible provides very good options for automation. With automation, people can focus on delivering smart solutions.</li>
        <li> Large-scale :Ansible can be used in small as well as very large-scale organizations.</li>
        <li>Simple DevOps : With Ansible, we can write automation in a human-readable language. This simplifies the task of DevOps.</li>
    </ol>
</details>

<details>
 <summary> 16.What are the main use cases of Ansible?</summary>
  <p>Some of the popular use cases of Ansible are as follows:</p>
    <ol>
        <li><b>AppDeployment</b> :With Ansible, we can deploy appsin a reliable and repeatable way.</li>
        <li><b>A ConfigurationManagement</b> :Ansible supports the automation of configuration management across multiple environments.</li>
        <li><b>Continuous Delivery</b> :We can release updates with zero downtime with Ansible</li>
        <li><b>Security </b>:We can implement complex security policies with Ansible</li>
        <li><b>Compliance </b>: Ansible helps in verifying and organization’s systems in comparison with the rules and regulations</li>
        <li><b>Provisioning</b> :We can provide newsystems and resources to other users with Ansible.</li>
        <li><b>Orchestration</b>:Ansible can be used in orchestration of complex deployment in a simple way</li>
    </ol>
</details>


<details>
 <summary>17.What is Docker Hub?</summary>
  <p>Docker Hub is a cloud-based registry. We can use Docker Hub to link code repositories. We can even build images and store them in Docker Hub. It also provides links to Docker Cloud to deploy the images to our hosts</p>
  <p>Docker Hub is a central repository for container image discovery, distribution, change management, workflow automation and team collaboration.</p>
</details>
