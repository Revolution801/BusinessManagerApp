// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
package com.revolutionlandscaping.businessmanager.services;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;

public interface IMainRest {

    @POST("/rest/main/get-accounts")
    Call<String> get_accounts(@Body String request);

    @POST("/rest/main/save-accounts")
    Call<String> save_accounts(@Body String request);

    @POST("/rest/main/delete-accounts")
    Call<String> delete_accounts(@Body String request);

    @POST("/rest/main/get-employees")
    Call<String> get_employees(@Body String request);

    @POST("/rest/main/save-employees")
    Call<String> save_employees(@Body String request);

    @POST("/rest/main/delete-employees")
    Call<String> delete_employees(@Body String request);

    @POST("/rest/main/get-jobs")
    Call<String> get_jobs(@Body String request);

    @POST("/rest/main/save-jobs")
    Call<String> save_jobs(@Body String request);

    @POST("/rest/main/delete-jobs")
    Call<String> delete_jobs(@Body String request);
}