from flask import Flask
import AccountFlask

app = Flask(__name__)

app.register_blueprint(AccountFlask.blueprint)

if __name__ == '__main__':
    app.run(host='127.0.0.2', port=80)