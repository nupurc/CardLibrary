<template>
    <div class="side-menu-container">
        <router-link to="/">
            <img id="imgLogo"
                 alt="Solar Coffee logo"
                 src="../assets/images/solar_coffee_logo.png" />
        </router-link>
        <h1><a id="menuhome" href="http://192.168.1.8:8081">Management Portal</a></h1>
        <a id="menuCard" href="http://localhost:8081/card">
            Card  Gallery    <i> </i>
        </a>
        <a id="menuCard" href="http://localhost:8081/user">
            User  Creation    <i> </i>
        </a>
        <a id="menuCard" href="http://localhost:8081/users">
            User  List    <i> </i>
        </a>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from "vue-property-decorator";
    import CardLibButton from "@/components/CardLibButton.vue";

    @Component({
        name: "SideMenu",
        components: { CardLibButton }
    })
    export default class SideMenu extends Vue {
        async goToRoute(route: string) {
            await this.$router.push(route);
        }
    }
</script>

<style scoped lang="scss">
    @import "@/scss/global.scss";
    a {
        color: #007bff;
        text-decoration: none;
        cursor: pointer;
        -webkit-transition: all .2s ease-in-out;
        transition: all .2s ease-in-out;
    }
    .solar-button {
        background: lighten($solar-blue, 10%);
        color: white;
        padding: 0.8rem;
        transition: background-color 0.5s;
        margin: 0.3rem 0.2rem;
        display: inline-block;
        cursor: pointer;
        font-size: 1rem;
        min-width: 100px;
        border: none;
        border-bottom: 2px solid darken($solar-blue, 20%);
        border-radius: 3px;
    }
    .side-menu-container {
        background-color: rgba(0, 0, 0, 0.24);
        height: 100vh;
        width: $menu-width;
        display: flex;
        flex-direction: column;
        padding: 0.8rem;
        box-shadow: 0 1px 1px rgba(0, 0, 0, 0.12), 0 1px 1px rgba(0, 0, 0, 0.24);
        box-sizing: border-box;
    }

    #imgLogo {
        width: 100%;
    }

    h1 {
        font-size: 1.2rem;
        margin: 1rem 0;
    }
</style>
