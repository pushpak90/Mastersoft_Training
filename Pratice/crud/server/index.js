const express = require('express')
const cors = require('cors')
const mongoose = require('mongoose')

const app = express()
app.use(cors())

const PORT = process.env.PORT || 8080

//Schema
const schemaData = mongoose.Schema({
    name : String,
    email : String,
    mobile : Number,
},{
    timestamps : true
})

const userModel = mongoose.model("user", schemaData)


app.get("/",(req,res)=>{
    res.json({message : "CRUD OPERATION"})
})

mongoose.connect("mongodb://localhost:27017//crudoperation")
.then(() => {
    console.log("DB connect")
    app.listen(PORT, () => console.log("server is running"))
})
.catch((err) => console.log(err))



