import axios from "axios";
import { API_URL } from "../api";

export const getGrades = async () => {
    const response = await axios.get(`${API_URL/Grade}`)
    return response.data
}

export const getGrade = async (id) => {
    const response = await axios.get(`${API_URL/Grade}/${id}`)
    return response.data
}

export const addGrade = async (grade) => {
    const response = await axios.post(`${API_URL/Grade/Interact}`, grade)
    return response.data
}

export const updateGrade = async (id,grade) => {
    const response = await axios.put(`${API_URL/Grade/Interact}/${id}`, grade)
    return response.data
}

export const deleteGrade = async (id) => {
    const response = await axios.delete(`${API_URL/Grade/Interact}/${id}`)
    return response.data
}