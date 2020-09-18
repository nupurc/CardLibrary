import Vue from 'vue';
import VueRouter from 'vue-router';
import Cards from '@/views/Card.vue';
import Users from '@/views/User.vue';
import UserList from '@/views/UserList.vue';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        name: 'home',
        component: Cards
    },
    {
        path: '/card',
        name: 'card',
        component: Cards
    },
    {
        path: '/user',
        name: 'users',
        component: Users
    }, 
    {
        path: '/users',
        name: 'userlist',
        component: UserList
    }, 
];

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
});

export default router;