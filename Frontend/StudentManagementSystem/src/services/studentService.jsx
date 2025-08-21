import axios from "axios";
import { API_URL } from "../api";

export const getStudents = async () => {
    const response = await axios.get(`${API_URL/Student}`)
    return response.data
}

export const getStudentById = async (id) => {
    const response = await axios.get(`${API_URL/Student}/${id}`)
    return response.data
}

export const addStudent = async (student) => {
    const response = await axios.post(`${API_URL/Student/Interact}`, student)
    return response.data
}

export const updateStudent = async (id,student) => {
    const response = await axios.put(`${API_URL/Student/Interact}/${id}`, student)
    return response.data
}

export const deleteStudent = async (id) => {
    const response = await axios.delete(`${API_URL/Student/Interact}/${id}`)
    return response.data
}