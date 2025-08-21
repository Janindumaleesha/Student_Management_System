import axios from "axios";
import { API_URL } from "../api";

export const getCourses = async () => {
    const response = await axios.get(`${API_URL/Course}`)
    return response.data
}

export const getCourseById = async (id) => {
    const response = await axios.get(`${API_URL/Course}/${id}`)
    return response.data
}

export const addCourse = async (course) => {
    const response = await axios.post(`${API_URL/Course/Interact}`, course)
    return response.data
}

export const updateCourse = async (id,course) => {
    const response = await axios.put(`${API_URL/Course/Interact}/${id}`, course)
    return response.data
}

export const deleteCourse = async (id) => {
    const response = await axios.delete(`${API_URL/Course/Interact}/${id}`)
    return response.data
}