from flask import Flask, render_template, request, redirect
app = Flask(__name__)

@app.route('/',methods=['POST'])
def survey():
    return render_template('survey.html')
@app.route('/result',methods=["POST"])
def go2():
    name = request.form['name']
    location = request.form['location']
    language = request.form['language']
    comment = request.form['comment']
    return render_template('result.html', name = name, location = location, language = language, comment = comment)

app.run(debug=True)
