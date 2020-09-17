import Vue from 'vue';
import VueRouter from 'vue-router';
import Cards from '@/views/Card.vue';
import Users from '@/views/User.vue';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        name: 'home',
        component: Card
    },
    {
        path: '/card',
        name: 'card',
        component: Card
    },
    {
        path: '/users',
        name: 'users',
        component: Users
    },    
];

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
});

export default router;