import re

valid_email = "social.ethosa@gmail.com"
valid_email1 = "SoCiAl.ETHOSA@GMAIL.COM"

email_rule = r"[\w\.]+@\w+\.\w+"

print(re.match(valid_email, email_rule, re.IGNORECASE))
