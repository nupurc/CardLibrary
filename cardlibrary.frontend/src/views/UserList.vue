<template>
    <section>
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
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">FirstName</th>
                    <th scope="col">LastName</th>
                    <th scope="col">User Name</th>
                    <th scope="col">Role</th>
                    <th scope="col">Group</th>
                </tr>
            </thead>
            <tbody>
                <tr>

                    <td>Nupur</td>
                    <td>Chatterjee</td>
                    <td>nupur</td>
                    <td>Admin</td>
                    <td>FFC</td>
                </tr>
                <tr>

                    <td>Paul</td>
                    <td>Williams</td>
                    <td>paul</td>
                    <td>Admin</td>
                    <td>ARC</td>
                </tr>
                <tr>

                    <td>Dennis</td>
                    <td>V</td>
                    <td>denv</td>
                    <td>Admin</td>
                    <td>HRA</td>
                </tr>
                <tr>

                    <td>Larry</td>
                    <td>V</td>
                    <td>lv</td>
                    <td>Admin</td>
                    <td>HRA</td>
                </tr>
                <tr>

                    <td>Mark</td>
                    <td>Otto</td>
                    <td>denv</td>
                    <td>Admin</td>
                    <td>HRA</td>
                </tr>
                <tr>

                    <td>Jacob</td>
                    <td>Thornton</td>
                    <td>denv</td>
                    <td>Admin</td>
                    <td>HRA</td>
                </tr>
                <tr>

                    <td>Larry</td>
                    <td>B</td>
                    <td>denv</td>
                    <td>Admin</td>
                    <td>HRA</td>
                </tr>
                <tr>

                    <td>Paul</td>
                    <td>Williams</td>
                    <td>denv</td>
                    <td>Admin</td>
                    <td>HRA</td>
                </tr>
            </tbody>
        </table>
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
    </section>
    
</template>

<script lang="ts">import { Component, Vue } from "vue-property-decorator";
    import CardLibButton from "@/components/CardLibButton.vue";
    import CardModal from "@/components/modals/CardModal.vue";
    import { IUserService } from "@/types/User";
    import { IUserGroupService } from "@/types/UserGroup";
    import { IUserRoleService } from "@/types/UserRole";

    @Component({
        name: "UserList",
        components: { CardLibButton, CardModal }
    })
    export default class UserList extends Vue {
        user: IUserService = {
            UserId:0,
            userName: "",
            password: "",
            createdOn: new Date(),
            updatedOn: new Date(),
            firstName: "",
            lastName: "",
            UserRoleId: 1,
            UserGroupId: 1
        };
        UserRole: IUserRoleService = {
            UserRoleId: 1,
            RoleName: "",
            createdOn: new Date(),
            updatedOn: new Date()
        };
        UserGroup: IUserGroupService = {
            UserGroupId: 1,
            GroupName: "",
            createdOn: new Date(),
            updatedOn: new Date()
        };

        save() {
            this.$emit("save:user", this.user);
        }

        close() {
            this.$emit("close");
        }
    }</script>

<style scoped lang="scss">
    .info-color-dark {
        background-color: #09c !important;
    }

    .text-center {
        text-align: center !important;
    }

    .pb-4, .py-4 {
        padding-bottom: 1.5rem !important;
    }

    .pt-4, .py-4 {
        padding-top: 1.5rem !important;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

    div {
        display: block;
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

    .nav-link {
        display: block;
        padding: .5rem 1rem;
    }

    a {
        color: #f5f5f5;
        text-decoration: none;
        cursor: pointer;
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
    }

    a {
        color: #555;
        text-decoration: none;
        background-color: transparent;
    }
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
    element.style {
    }

    .table {
        width: 100%;
        margin-bottom: 1rem;
        color: #212529;
    }

    table {
        border-collapse: collapse;
    }

    *, *::before, *::after {
        box-sizing: border-box;
    }

    nav {
        display: block;
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

    .main-tabs-docs .nav-mtd {
        white-space: nowrap;
        overflow-x: auto;
        position: relative;
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
    table {
        display: table;
        border-collapse: separate;
        box-sizing: border-box;
        border-spacing: 2px;
        border-color: grey;
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