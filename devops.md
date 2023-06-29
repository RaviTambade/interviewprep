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
        <li> <b>Release Velocity</b> : DevOps practices help in increasing the release velocity. We can release code to
productionmore oftenand withmore confidence.</li>
        <li><b>Development Cycle</b> : With DevOps, the complete Development cycle from initial design to production
deployment becomesshorter</li>
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
