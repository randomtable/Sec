# SCAP Content and Installation Tools:

### Important Update
#### I'm performing continuous tests, and i have seen an anomaly on Windows 10 1809 if the "Bypass traverse checking" configuration is not set on "Everyone".
#### For this reason, i have updated the configuration on all files.
#### If you find a malfunction (the configs shall works from Windows 7 to Windows 10 - Including server editions), don't hesitate to open an issue.

Use this Checklist for configure your Systems to a specific Environment setting.

Environments are specified in NIST Special Publication " NIST SP 800-70 ":

## 3.1 Standalone Environment

The Standalone environment describes individually managed devices (e.g., desktops, laptops,
smartphones, tablets), as opposed to Managed environments (see Section 3.2), which are based on
centrally managed devices (i.e., many devices managed by a single organization). Standalone
environments are typically the least secured. The individuals who maintain Standalone systems are not
assumed to use the same enterprise security controls and possess the same general security expertise as
trained administrators. Less secure environments often occur when functionality is the main focus and not
enough emphasis is placed on balancing device security and functionality. Accordingly, Standalone
checklists should be relatively simple to understand and implement by home users or novice system
administrators.

## 3.2 Managed Environment

The Managed environment, also referred to as Enterprise, comprises centrally managed IT products,
everything ranging from servers and printers to desktops, laptops, smartphones, and tablets. Managed
checklists are intended for advanced end users and system administrators. The managed nature of typical
Managed environments gives administrators centralized control over various settings on devices.
Authentication, account, and policy management can also be administered centrally to maintain a
consistent security posture across an organization.

## 3.3 Specialized Security-Limited Functionality Custom Environment

A Custom environment contains systems in which the functionality and degree of security do not fit the
other types of environments. Specialized Security-Limited Functionality (SSLF) is a typical Custom
environment that is highly restrictive and secure; it is usually reserved for systems that have the highest
threats and associated impacts. Typical examples of such systems are outward-facing web, email, and
DNS servers, other publicly accessed systems, and firewalls. It also encompasses computers that contain
confidential information (e.g., central repository of personnel records, medical records, and financial
information) or that perform vital organizational functions (e.g., accounting, payroll processing, and air
traffic control). These systems might be targeted by third parties for exploitation, but also might be
targeted by trusted parties inside the organization. Because systems in an SSLF environment are at high
risk of attack or data exposure, security takes precedence over functionality. The systems’ data content or
mission purpose is of such value that aggressive tradeoffs in favor of security outweigh the potential
negative consequences to other useful system attributes such as legacy applications or interoperability
with other systems.
An SSLF environment could be a subset of another environment. For example, three desktops in a
Managed environment that hold the organization’s confidential employee data could be thought of as an
SSLF environment within a Managed environment. In addition, a laptop used by a mobile worker (e.g.,
organization management) might be an SSLF environment in a Standalone environment. An SSLF
environment might also be a self-contained environment outside any other environment, such as a
government security installation processing sensitive data.
SSLF checklists are intended for experienced security specialists and seasoned system administrators who
understand the impact of implementing strict technical security practices. If home users and other users
who do not have security expertise attempt to apply SSLF checklists to their systems, they typically
experience unwanted limitations on system functionality and cause possibly irreparable system damage.

## 3.5 United States Government Environment

A United States Government environment is another example of a Custom environment. This
environment contains federal government systems. These systems need to be secured according to
prescribed configurations as mandated by policy. For example, the Federal Desktop Core Configuration
(FDCC) is a security configuration policy mandated by the Office of Management and Budget (OMB).
The original checklists developed in support of the FDCC policy exist for multiple versions of Microsoft
Windows, Windows Firewall, and Internet Explorer. These checklists are broader than previous
checklists, incorporating settings for Web browsers, personal firewalls, and other software. The
configuration settings also include non security-related settings aimed at improving performance, energy
efficiency, compatibility, and interoperability. The settings are largely based on the configuration settings
recommended by Microsoft in its security guides, but they have been customized to take into account
federal government security requirements. Many federal systems have been required to use these
checklists by OMB’s FDCC mandate.
Since that time, the US government has focused on developing a new set of security configuration
checklists to augment the existing checklists in support of the FDCC policy. These new checklists are
known as the United States Government Configuration Baseline (USGCB). Like the original checklists,
the USGCB checklists also support the FDCC policy, and the USGCB checklists address a wide variety
of security and non-security settings that are largely based on settings recommended by product vendors
but customized to meet federal requirements. The USGCB initiative was created in 2010 by the
Technology Infrastructure Subcommittee (TIS) of the CIO Council Architecture and Infrastructure
Committee (AIC) as an evolution of the FDCC policy. The USGCB checklists are referred to as
“baselines” because they define minimum sets of configurations that must be implemented. New USGCB
baselines were released to replace the original FDCC checklists (Windows XP, Windows Vista, and
Internet Explorer 7), and the original FDCC checklists were deprecated at that time. USGCB checklists
have also been created for other platforms, namely Red Hat Enterprise Linux Desktop.
The USGCB configuration settings are intended to be deployed primarily to managed systems. The
original checklists in support of the FDCC policy and USGCB baselines are intended to be applied to
systems primarily through automated tools. Organizations should thoroughly test all checklists and
baselines before deploying them in operational environments because a number of their settings, such as
cryptographic algorithm options and wireless services, may impact system functionality. After
deployment, settings may also be checked through automated means for compliance with checklists and
baselines.

Just run the script named as Environment you want to set, contained in folder:
https://github.com/randomtable/Sec/tree/master/SCAPVal/SCAP%20Installation%20scripts
To set your System.

To revert the configuration, use the "BASE" configuration.

All Scripts requires administrative privileges to run.
