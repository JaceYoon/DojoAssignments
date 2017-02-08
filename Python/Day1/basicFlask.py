from flask import Flask
app = Flask(__name__)

@appt.route('/'):
    def index():
        pass

app.run()#optional parameter : debut=True
