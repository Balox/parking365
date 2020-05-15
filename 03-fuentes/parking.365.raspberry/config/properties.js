module.exports.production = {
    HOSTNAME: "::",
    PORT: 5000,
    MONGODB_URI: "mongodb://localhost:27017/parking365",
    JWT_SECRET: "pArK1nG-365@2020",
    JWT_EXP: "12h",
    JWT_PATH_PRIVATE: "./prod/jwtRS256.key",
    JWT_PATH_PUBLIC: "./prod/jwtRS256.key.pub",
    ENV_DEV: false,
    SHOW_LOG: false
}