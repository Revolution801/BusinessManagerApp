// THIS FILE WAS AUTO-GENERATED. DO NOT ALTER!
package com.revolutionlandscaping.businessmanager.rest;

import org.roylance.common.service.IProtoSerializerService;

import com.revolutionlandscaping.businessmanager.utilities.ServiceLocator;
import com.revolutionlandscaping.businessmanager.services.IMainService;

import javax.servlet.ServletContext;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.container.AsyncResponse;
import javax.ws.rs.container.Suspended;
import javax.ws.rs.core.Context;

@Path("/main")
public class MainController {
    @Context
    private ServletContext context;
    @Context
    private HttpServletRequest request;
    @Context
    private HttpServletResponse response;

    private final IMainService mainService;
    private final IProtoSerializerService serializerService;

    public MainController() {
        this.serializerService = ServiceLocator.INSTANCE.getProtobufSerializerService();
        this.mainService = ServiceLocator.INSTANCE.getMainService();
    }

    @POST
    @Path("/get-accounts")
    public void get_accounts(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.get_accounts(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/save-accounts")
    public void save_accounts(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.save_accounts(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/delete-accounts")
    public void delete_accounts(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.delete_accounts(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/get-employees")
    public void get_employees(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.get_employees(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/save-employees")
    public void save_employees(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.save_employees(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/delete-employees")
    public void delete_employees(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.delete_employees(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/get-jobs")
    public void get_jobs(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.get_jobs(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/save-jobs")
    public void save_jobs(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.save_jobs(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }

    @POST
    @Path("/delete-jobs")
    public void delete_jobs(@Suspended AsyncResponse asyncResponse, String request) throws Exception {
        new Thread(() -> {
            
            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest requestActual =
                    this.serializerService.deserializeFromBase64(request, com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerRequest.getDefaultInstance());

            final com.revolutionlandscaping.businessmanager.BusinessManagerModel.UIBusinessManagerResponse response = this.mainService.delete_jobs(requestActual);
            final String deserializeResponse = this.serializerService.serializeToBase64(response);
            asyncResponse.resume(deserializeResponse);

        }).start();
    }
}