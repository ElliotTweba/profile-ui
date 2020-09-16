import { ProfileDetail } from './profile-detail.model';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ProfileDetailService {

  formData:  ProfileDetail= new  ProfileDetail();
  readonly rootURL = 'http://localhost:54139/api/Profile';
  list : ProfileDetail[];

  constructor(private http: HttpClient) { }

  postProfileDetail() {
    return this.http.post(`${this.rootURL}/ProfileDetail`, this.formData);
  }
  putProfileDetail() {
    return this.http.put(`${this.rootURL}/ProfileDetail/${this.formData.PID}`, this.formData);
  }
  deleteProfileDetail(id) {
    return this.http.delete(`${this.rootURL}/ProfileDetail/${id}`);
  }

  refreshList() {
    this.http.get(`${this.rootURL}`)
      .toPromise()
      .then(res => {console.log(res);this.list = res as ProfileDetail[]});
  }
}