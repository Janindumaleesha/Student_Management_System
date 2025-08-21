import axios from "axios";
import { API_URL } from "../api";

export const getTeachers = async () => {
    const response = await axios.get(`${API_URL/Teacher}`)
    return response.data
}

export const getTeacherById = async (id) => {
    const response = await axios.get(`${API_URL/Teacher}/${id}`)
    return response.data
}

export const addTeacher = async (teacher) => {
    const response = await axios.post(`${API_URL/Teacher/Interact}`, teacher)
    return response.data
}

export const updateTeacher = async (id,teacher) => {
    const response = await axios.put(`${API_URL/Teacher/Interact}${id}`, teacher)
    return response.data
}

export const deleteTeacher = async (id) => {
    const response = await axios.delete(`${API_URL/Teacher/Interact}/${id}`)
    return response.data
}

