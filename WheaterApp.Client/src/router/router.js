import { createRouter, createWebHistory } from "vue-router";
import Home from "../views/Home.vue";
import SignUp from "../views/SignUp.vue";
import SignIn from "../views/SignIn.vue";
import { APP_ROUTE_NAMES } from "../constants/routenames.js";
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    { path: "/", component: Home, name: APP_ROUTE_NAMES.HOME },
    { path: "/sign-up", component: SignUp, name: APP_ROUTE_NAMES.SING_UP },
    { path: "/sign-in", component: SignIn, name: APP_ROUTE_NAMES.SIGN_IN },
  ],
});

export default router;
