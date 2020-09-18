<template>   
        
    <div class="main-tabs-docs">
        <section>
            <ul class="nav grey lighten-4 py-4">
                <li class="nav-item">
                    <a class="nav-link active" href="#!">Card Gallery</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#!">User</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#!">Feature Team</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link " href="#!">Contact Us</a>
                </li>
            </ul>
        </section>
        <form class="mx-xl-5 waves-effect">
            <!-- Material input text -->
            <div class="md-form">
                <i class="fas fa-user prefix grey-text"></i>
                <input type="text" id="materialFormRegisterNameEx" class="form-control">
                <label for="materialFormRegisterNameEx">First Name</label>
            </div>

            <!-- Material input email -->
            <div class="md-form">
                <i class="fas fa-envelope prefix grey-text"></i>
                <input type="text" id="materialFormRegisterEmailEx" class="form-control">
                <label for="materialFormRegisterEmailEx">Last Name</label>
            </div>

            <!-- Material input email -->
            <div class="md-form">
                <i class="fas fa-exclamation-triangle prefix grey-text"></i>
                <input  id="materialFormRegisterConfirmEx" class="form-control">
                <label for="materialFormRegisterConfirmEx">User Name</label>
            </div>

            <!-- Material input password -->
            <div class="md-form">
                <i class="fas fa-lock prefix grey-text"></i>
                <input type="password" id="materialFormRegisterPasswordEx" class="form-control">
                <label for="materialFormRegisterPasswordEx">Password</label>
            </div>
            <div class="md-form">
                <i class="fas fa-lock prefix grey-text"></i>
                <select class="form-control select-dropdown" id="usrRole">
                    <option disabled selected="selected">Admin</option>
                </select>
            </div>
            <div class="mt-4">
                <button class="btn btn-primary btn-unique" type="submit">Register</button>
            </div>
        </form>
        <footer id="footer" class="page-footer center-on-small-only unique-color-dark pt-0">
            <div class="info-color-dark text-center py-4">

                <!--Newsletter-->
                <a id="footer-link-vue-newsletter" href="/docs/newsletter/" class="border rounded p-2 px-3 mr-4 d-none d-md-inline-block">
                    Join our newsletter      <i class="fas fa-envelope white-text ml-2"> </i>
                </a>
                <!--Newsletter-->
                <a id="footer-link-vue-affiliate" href="/mdb-affiliate-program/" class="border rounded p-2 px-3 mr-4 d-none d-md-inline-block">
                    Become an Affiliate      <i class="fas fa-money-bill-alt white-text ml-2"> </i>
                </a>
                <!--Contact-->
                <a id="footer-link-vue-contact" href="/general/contact/" class="border rounded p-2 px-3 mr-4 d-none d-md-inline-block">
                    Contact us      <i class="fas fa-envelope white-text ml-2"> </i>
                </a>
                <!--GitHub-->
                <a rel="nofollow" target="_blank" id="footer-link-vue-github" href="#">
                    <i class="fab fa-github white-text mr-4"> </i>
                </a>
                <!--Youtube-->
                <a rel="nofollow" target="_blank" href="https://www.youtube.com/watch?v=s6ox3b9Xedc">
                    <i class="fab fa-youtube white-text mr-4"> </i>
                </a>
                <!--Facebook-->
                <a rel="nofollow" target="_blank" id="footer-link-vue-facebook" href="https://www.facebook.com/mdbootstrap">
                    <i class="fab fa-facebook-f white-text mr-4"> </i>
                </a>
                <!--Twitter-->
                <a rel="nofollow" target="_blank" id="footer-link-vue-twitter" href="https://twitter.com/MDBootstrap">
                    <i class="fab fa-twitter white-text mr-4"> </i>
                </a>

            </div>
        </footer>
    </div>
       
</template>
<style scoped lang="scss">
    .text-center {
        text-align: center !important;
    }

    .pb-4, .py-4 {
        padding-bottom: 1.5rem !important;
    }

    .pt-4, .py-4 {
        padding-top: 1.5rem !important;
    }
    .info-color-dark {
        background-color: #09c !important;
    }
    .nav-link {
        display: block;
        padding: .5rem 1rem;
    }

    a {
        color: #007bff;
        text-decoration: none;
        cursor: pointer;
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
    }

    a {
        color: #007bff;
        text-decoration: none;
        background-color: transparent;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

   
    a:-webkit-any-link {
        color: -webkit-link;
        cursor: pointer;
        text-decoration: underline;
    }

    .nav li {
        list-style: none;
    }

  
    li {
        text-align: -webkit-match-parent;
    }

    .nav {
        display: -ms-flexbox;
        display: flex;
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        padding-left: 0;
        margin-bottom: 0;
        list-style: none;
    }

   
    ul {
        list-style-type: disc;
    }
    .nav li {
        list-style: none;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

  
    li {
        display: list-item;
        text-align: -webkit-match-parent;
    }

    .nav {
        display: -ms-flexbox;
        display: flex;
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        padding-left: 0;
        margin-bottom: 0;
        list-style: none;
    }

    
    ul {
        list-style-type: disc;
    }

    .grey.lighten-4 {
        background-color: #f5f5f5 !important;
    }

    .grey {
        background-color: #9e9e9e !important;
    }

    .pb-4, .py-4 {
        padding-bottom: 1.5rem !important;
    }

    .pt-4, .py-4 {
        padding-top: 1.5rem !important;
    }

    .nav {
        display: -ms-flexbox;
        display: flex;
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        padding-left: 0;
        margin-bottom: 0;
        list-style: none;
    }

    ol, ul, dl {
        margin-top: 0;
        margin-bottom: 1rem;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

    user agent stylesheet
    ul {
        display: block;
        list-style-type: disc;
        margin-block-start: 1em;
        margin-block-end: 1em;
        margin-inline-start: 0px;
        margin-inline-end: 0px;
        padding-inline-start: 40px;
    }
    .nav-tabs .nav-item {
        margin-bottom: -1px;
    }

    .nav li {
        list-style: none;
    }

    .waves-effect {
        position: relative;
        overflow: hidden;
        cursor: pointer;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        -webkit-tap-highlight-color: transparent;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

    user agent stylesheet
    li {
        display: list-item;
        text-align: -webkit-match-parent;
    }

    .nav {
        display: -ms-flexbox;
        display: flex;
        -ms-flex-wrap: wrap;
        flex-wrap: wrap;
        padding-left: 0;
        margin-bottom: 0;
        list-style: none;
    }    
    ul {
        list-style-type: disc;
    }
    .nav-tabs .nav-link {
        border: 1px solid transparent;
        border-top-left-radius: .25rem;
        border-top-right-radius: .25rem;
    }

    .ripple-parent {
        position: relative;
        overflow: hidden;
        cursor: pointer;
    }
    html {
        font-family: sans-serif;
        line-height: 1.15;
        -webkit-text-size-adjust: 100%;
        -webkit-tap-highlight-color: rgba(0,0,0,0);
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }
    .select-wrapper .select-dropdown {
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

    user agent stylesheet
    div {
        display: block;
    }

    .md-form {
        position: relative;
        margin-top: 1.5rem;
        margin-bottom: 1.5rem;
    }
    .form-control {
        display: block;
        width: 50%;
        height: calc(1.5em + 0.75rem + 2px);
        padding: .375rem .75rem;
        font-size: 1rem;
        font-weight: 400;
        line-height: 1.5;
        color: #495057;
        background-color: #fff;
        background-clip: padding-box;
        border: 1px solid #ced4da;
        border-radius: .25rem;
        transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
    }

    button, input {
        overflow: visible;
    }

    input, button, select, optgroup, textarea {
        margin: 0;
        font-family: inherit;
        font-size: inherit;
        line-height: inherit;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }
        
    input[type="password" i] {
        -webkit-text-security: disc !important;
        padding: 1px 2px;
    }
 
    input {
        -webkit-writing-mode: horizontal-tb !important;
        text-rendering: auto;
        color: -internal-light-dark(black, white);
        letter-spacing: normal;
        word-spacing: normal;
        text-transform: none;
        text-indent: 0px;
        text-shadow: none;
        display: inline-block;
        text-align: start;
        appearance: textfield;
        background-color: -internal-light-dark(rgb(255, 255, 255), rgb(59, 59, 59));
        -webkit-rtl-ordering: logical;
        cursor: text;
        margin: 0em;
        font: 400 13.3333px Arial;
        padding: 1px 2px;
        border-width: 2px;
        border-style: inset;
        border-color: -internal-light-dark(rgb(118, 118, 118), rgb(195, 195, 195));
        border-image: initial;
    }
    .text-center {
        text-align: center !important;
    }

    .mt-4, .my-4 {
        margin-top: 1.5rem !important;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }    
    div {
        display: block;
    }

    body {
        font-family: "Roboto",sans-serif;
        font-weight: 300;
    }
    .btn-unique {
        color: #fff;
        background-color: #6c757d !important;
    }

    .btn {
        margin: .375rem;
        color: inherit;
        text-transform: uppercase;
        word-wrap: break-word;
        white-space: normal;
        cursor: pointer;
        border: 0;
        border-radius: .125rem;
        -webkit-box-shadow: 0 2px 5px 0 rgba(0,0,0,0.16), 0 2px 10px 0 rgba(0,0,0,0.12);
        box-shadow: 0 2px 5px 0 rgba(0,0,0,0.16), 0 2px 10px 0 rgba(0,0,0,0.12);
        -webkit-transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,-webkit-box-shadow .15s ease-in-out;
        transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,-webkit-box-shadow .15s ease-in-out;
        transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;
        transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out,-webkit-box-shadow .15s ease-in-out;
        padding: .84rem 2.14rem;
        font-size: .81rem;
    }

    .waves-effect {
        position: relative;
        overflow: hidden;
        cursor: pointer;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        -webkit-tap-highlight-color: transparent;
    }

    .btn {
        display: inline-block;
        font-weight: 400;
        color: #212529;
        text-align: center;
        vertical-align: middle;
        cursor: pointer;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        background-color: transparent;
        border: 1px solid transparent;
        padding: .375rem .75rem;
        font-size: 1rem;
        line-height: 1.5;
        border-radius: .25rem;
        transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;
    }
    button, select {
        text-transform: none;
    }

    button, input {
        overflow: visible;
    }

    input, button, select, optgroup, textarea {
        margin: 0;
        font-family: inherit;
        font-size: inherit;
        line-height: inherit;
    }

    button {
        border-radius: 0;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

    
    button {
        appearance: button;
        -webkit-writing-mode: horizontal-tb !important;
        text-rendering: auto;
        color: -internal-light-dark(buttontext, rgb(170, 170, 170));
        letter-spacing: normal;
        word-spacing: normal;
        text-transform: none;
        text-indent: 0px;
        text-shadow: none;
        display: inline-block;
        text-align: center;
        align-items: flex-start;
        cursor: default;
        background-color: -internal-light-dark(rgb(239, 239, 239), rgb(74, 74, 74));
        box-sizing: border-box;
        margin: 0em;
        font: 400 13.3333px Arial;
        padding: 1px 6px;
        border-width: 2px;
        border-style: outset;
        border-color: -internal-light-dark(rgb(118, 118, 118), rgb(195, 195, 195));
        border-image: initial;
    }

    .text-center {
        text-align: center !important;
    }

    body {
        font-family: "Roboto",sans-serif;
        font-weight: 300;
    }

    body {
        margin: 0;
        font-family: -apple-system,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,"Noto Sans",sans-serif,"Apple Color Emoji","Segoe UI Emoji","Segoe UI Symbol","Noto Color Emoji";
        font-size: 1rem;
        font-weight: 400;
        line-height: 1.5;
        color: #212529;
        text-align: left;
        background-color: #fff;
    }

    :root {
        --blue: #007bff;
        --indigo: #6610f2;
        --purple: #6f42c1;
        --pink: #e83e8c;
        --red: #dc3545;
        --orange: #fd7e14;
        --yellow: #ffc107;
        --green: #28a745;
        --teal: #20c997;
        --cyan: #17a2b8;
        --white: #fff;
        --gray: #6c757d;
        --gray-dark: #343a40;
        --primary: #007bff;
        --secondary: #6c757d;
        --success: #28a745;
        --info: #17a2b8;
        --warning: #ffc107;
        --danger: #dc3545;
        --light: #f8f9fa;
        --dark: #343a40;
        --breakpoint-xs: 0;
        --breakpoint-sm: 576px;
        --breakpoint-md: 768px;
        --breakpoint-lg: 992px;
        --breakpoint-xl: 1200px;
        --font-family-sans-serif: -apple-system,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,"Noto Sans",sans-serif,"Apple Color Emoji","Segoe UI Emoji","Segoe UI Symbol","Noto Color Emoji";
        --font-family-monospace: SFMono-Regular,Menlo,Monaco,Consolas,"Liberation Mono","Courier New",monospace;
    }

    :root {
        --wp-admin-theme-color: #007cba;
        --wp-admin-theme-color-darker-10: #006ba1;
        --wp-admin-theme-color-darker-20: #005a87;
    }

    html {
        font-family: sans-serif;
        line-height: 1.15;
        -webkit-text-size-adjust: 100%;
        -webkit-tap-highlight-color: rgba(0,0,0,0);
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

        *, *::before, *::after {
            box-sizing: border-box;
        }
</style>
    <script lang="ts" >
    import {
        Component, Vue
    }

    from "vue-property-decorator";
    import CardLibButton from "@/components/CardLibButton.vue";
    import CardModal from "@/components/modals/CardModal.vue";
    import {
        IUserService
    }

    from "@/types/User";
    import {
        IUserGroupService
    }

    from "@/types/UserGroup";
    import {
        IUserRoleService
    }

    from "@/types/UserRole";

    @Component({
        name: "NewUserModal",
        components: { CardLibButton, CardModal }
    })
    export default class NewUserModal extends Vue {
        user: IUserService =

    {
        UserId: 0, userName: "", password: "", createdOn: new Date(), updatedOn: new Date(), firstName: "", lastName: "", UserRoleId: 1, UserGroupId: 1
    }

    ;
    UserRole: IUserRoleService = {
        UserRoleId: 1, RoleName: "", createdOn: new Date(), updatedOn: new Date()
    }

    ;
    UserGroup: IUserGroupService = {
        UserGroupId: 1, GroupName: "", createdOn: new Date(), updatedOn: new Date()
    }

    ;

    save() {
        this .$emit("save:user", this.user);
    }

    close() {
        this .$emit("close");
    }

    }

    </script >

    <style scoped lang="scss" >
    .newUser {
        display: flex;
        flex-wrap: wrap;
        list-style: none;
        padding: 0;
        margin: 0;
    }

    input {
        width: 80%;
        height: 1.8rem;
        margin: 0.8rem 2rem 0.8rem 0.8rem;
        font-size: 1.1rem;
        line-height: 1.3rem;
        padding: 0.2rem;
        color: #555;
    }

    label {
        font-weight: bold;
        margin: 0.8rem;
        display: block;
    }
</style>