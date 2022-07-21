#VSC API

-[VSC API](#vsc-api) -[AUTH](#auth) -[Register](#register) -[Register Request](#register-request) -[Register Response](#register-response) -[Login](#login) -[Login Request](#login-response) -[Login Response](#login-response)

## Auth

## Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "johndoe@gmail.com",
  "password": "1234567890"
}
```

#### Register Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "John",
  "lastName": "Doe",
  "email": "johndoe@gmail.com",
  "token": "eyjhb..hbbQ"
}
```

## Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "John",
  "lastName": "Doe",
  "email": "johndoe@gmail.com",
  "token": "eyjhb..hbbQ"
}
```

#### Login Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a-eb3e-4075-95ff-b920b55aa104",
  "firstName": "John",
  "lastName": "Doe",
  "email": "johndoe@gmail.com",
  "token": "eyjhb..hbbQ"
}
```
