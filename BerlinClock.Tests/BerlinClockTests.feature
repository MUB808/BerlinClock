Feature: BerlinClockTests
	Descpription

@mytag
Scenario: Scenario 1
	When The time is "24:00:00"
	Then The clock should look like
"""
Y
RRRR
RRRR
OOOOOOOOOOO
OOOO
"""

Scenario: Scenario 2
	When The time is "05:20:05"
	Then The clock should look like
"""
O
ROOO
RRRR
YYRYOOOOOOO
OOOO
"""

Scenario: Scenario 3
	When The time is "11:42:16"
	Then The clock should look like
"""
Y
RROO
ROOO
YYRYYRYYOOO
YYOO
"""

Scenario: Scenario 4
	When The time is "15:59:25"
	Then The clock should look like
"""
O
RRRO
RRRR
YYRYYRYYRYY
YYYY
"""
Scenario: Scenario 5
	When The time is "20:01:45"
	Then The clock should look like
"""
O
RRRR
OOOO
OOOOOOOOOOO
YOOO
"""

Scenario: Scenario 6
	When The time is "23:12:59"
	Then The clock should look like
"""
O
RRRR
RRRO
YYOOOOOOOOO
YYOO
"""
