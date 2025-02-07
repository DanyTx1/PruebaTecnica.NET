import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private apiUrl = 'https://localhost:7056/Api/Alumno'; // URL base del back-end

  constructor(private http: HttpClient) {}

  // Método para obtener alumnos por grado
  getAlumnosByGrado(grado: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}?grado=${grado}`);
  }

  registrarAlumno(alumno: any): Observable<any> {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.post<any>(this.apiUrl, alumno, { headers });
  }
}
