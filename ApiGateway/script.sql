CREATE TABLE product
(
    id bigserial NOT NULL,
    name text NOT NULL,
    description text,
    PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
);

ALTER TABLE product
    OWNER to postgres;
	