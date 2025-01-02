from flask import Flask, request, jsonify, Blueprint

from EmployeeAdapter import EmployeeAdapter
employeeAdapter = EmployeeAdapter()

blueprint = Blueprint('test', __name__)

@blueprint.route('/verify', methods=['POST'])
def login():
    try:
        data = request.get_json()
        staffID = data.get('id')
        password = data.get('password')
        employeeData = employeeAdapter.getEmployeeData(staffID, password)
        if not employeeData[0]:
            return jsonify(success="false")
        else:
            return jsonify(success="true", positionName=employeeData[0], staffName=employeeData[1], emailAddress=employeeData[2])
    except:
        print("login flask error")
        return jsonify(success="false")  # Return a JSON response login fail
    
@blueprint.route('/account/getpermission', methods=['GET'])
def getpermission():
    try:
        position = request.args.get('position')
        permissions = employeeAdapter.getPositionPermission(position)
        jsonStr = {
            'success': "true",
            'permissions': permissions
        }
        return jsonify(jsonStr)
    except:
        print('get permission error')
        return jsonify(success='false')
    
@blueprint.route('/account/getAccounts', methods=['POST'])
def getAccounts():
    try:
        data = request.get_json()
        staffID = data.get('id')
        password = data.get('password')
        employeeData = employeeAdapter.getEmployeeData(staffID, password)
    except:
        print('getAccounts error')
        return jsonify(success='false')
