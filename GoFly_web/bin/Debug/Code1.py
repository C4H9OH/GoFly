import telegram_send

try:
	file = open('Message.txt','r')
	s = file.read()	
except FileNotFoundError:
	print("Misstake")
telegram_send.send(messages=[s])
