Feature: Profile
In order to add my Profile Details
As a User I want to be able to add, Update and  delete languages,Skills,educaton and certification

Background:
	Given User is using chrome browser
	When Navigate to "http://localhost:5000/Home" url
	And Enter valid login credentials "shriya1.gajjar@gmail.com" and "Shriya@2906"
	Then verify user is logged in

Scenario Outline:1 Add Language to the profile
	Given User click Languages tab in profile page
	And User click Add New Language button
	When add new language < Language > and < LanguageLevel >
	Then language should be added

	Examples:
		| Language | LanguageLevel  |
		| English  | Conversational |

Scenario Outline:2 Edit language successfully
	Given User is click on the Languages tab in profile page
	And User is click on Edit Language button
	When User update Language information < LanguageLevel >
	Then updated detail should be visible on the Languages page

	Examples:
		| Language | LanguageLevel |
		| English  | Fluent        |

Scenario Outline:3 Delete Language successfully
	Given User is click on the Languages tab in profile page
	When User is click on the Delete Languages button
	Then Languages should be deleted on the Languages page

Scenario Outline:4 Add Skills to the profile
	Given User click on the Skills tab in profile page
	And User clicks on Add New Skill button
	When User add new skills < Skill > and < Level >
	Then The should be added to the Skills page

	Examples:
		| Skill   | Level        |
		| Testing | intermidiate |

Scenario Outline:5 Edit Skills successfully
	Given User click on the Skills tab in profile page
	And User click on Edit Skill button
	When User update the Skills information < Level >
	Then that updated details should be visible on the Skills page

	Examples:
		| Skill   | Level  |
		| Testing | Expert |

Scenario Outline:6 Delete Skill successfully
	Given User click on the Skills tab in profile page
	When User click on Delete Skill button
	Then that Skills should not be visible on the Skills page

Scenario Outline:7 Add Education to the profile
	Given User click on the Education tab in profile page
	And User clicks on the Add New Education button
	When User adds a new Education < college/universityname > ,< country >,< Title >,< degree > and < yearofgraduation >
	Then The Education should be added to the Education page

	Examples:
		| collegename | country | Title  | degree      | yearofgraduation |
		| GTU                    | India   | B.Tech | engineering | 2016             |

Scenario Outline:8 Edit Education successfully
	Given User click on the Education tab in profile page
	And User clicks on Edit Education button
	When User updates the Education year < yearofgraduation >
	Then that updated details should be visible on the Education page

	Examples:
		| collegename | country | Title  | degree      | yearofgraduation |
		| GTU                    | India   | B.Tech | engineering | 2015             |

Scenario Outline:9 Delete Education successfully
	Given User click on the Education tab in profile page
	When User clicks on the Delete Education button
	Then that Education should not be visible on the Education page

Scenario Outline:10 Add Certificate
	Given user click on the Certificate tab in profile page
	And User click on the Add New Certificate button
	When User add new Certificate  < Certificate >,< CertificateFrom > and < Year >
	Then certificate details added to the Certifications page

	Examples:
		| Certificate | CertificateFrom | Year |
		| ISTQB       | BCS             | 2020 |

Scenario Outline:11 Edit certificate successfully
	Given User is click on the Certifications tab in profile page
	And User is clicks on Edit Certificate button
	When Update Certifications year < year >
	Then updated detail should be visible on the Certifications page

	Examples:
		| Certificate | CertificateFrom | Year |
		| ISTQB       | BCS             | 2019 |

Scenario Outline:12 delete certificate successfully
	Given User click on the Certifications tab in profile page
	When User click on the Delete Certificate button
	Then certificate should not be visible on the Certifications page