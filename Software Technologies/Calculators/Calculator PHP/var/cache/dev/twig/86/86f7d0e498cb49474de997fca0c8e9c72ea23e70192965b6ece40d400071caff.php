<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_1f8cb108162d7646272e4db14d222f1f57c6f0235ae9d815b226a981890b4349 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_86900d563cc6630f6c0afa46e8f4cb09d9bee300e534c0066ce406c0bede63b4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_86900d563cc6630f6c0afa46e8f4cb09d9bee300e534c0066ce406c0bede63b4->enter($__internal_86900d563cc6630f6c0afa46e8f4cb09d9bee300e534c0066ce406c0bede63b4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_86900d563cc6630f6c0afa46e8f4cb09d9bee300e534c0066ce406c0bede63b4->leave($__internal_86900d563cc6630f6c0afa46e8f4cb09d9bee300e534c0066ce406c0bede63b4_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_c481adc4326755783f012f7d264e1aee2b7507f547dc5aefddf77632b0a9de66 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c481adc4326755783f012f7d264e1aee2b7507f547dc5aefddf77632b0a9de66->enter($__internal_c481adc4326755783f012f7d264e1aee2b7507f547dc5aefddf77632b0a9de66_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_c481adc4326755783f012f7d264e1aee2b7507f547dc5aefddf77632b0a9de66->leave($__internal_c481adc4326755783f012f7d264e1aee2b7507f547dc5aefddf77632b0a9de66_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_49c31236a3ee6542ae8045daeeda17151a9e3a0a451d4e3d68e53204cf55bf33 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_49c31236a3ee6542ae8045daeeda17151a9e3a0a451d4e3d68e53204cf55bf33->enter($__internal_49c31236a3ee6542ae8045daeeda17151a9e3a0a451d4e3d68e53204cf55bf33_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_49c31236a3ee6542ae8045daeeda17151a9e3a0a451d4e3d68e53204cf55bf33->leave($__internal_49c31236a3ee6542ae8045daeeda17151a9e3a0a451d4e3d68e53204cf55bf33_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_165f9bac4a4e7c6591657ea615bd52b3da4d285bb2197d62624e96be7ea686cd = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_165f9bac4a4e7c6591657ea615bd52b3da4d285bb2197d62624e96be7ea686cd->enter($__internal_165f9bac4a4e7c6591657ea615bd52b3da4d285bb2197d62624e96be7ea686cd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_165f9bac4a4e7c6591657ea615bd52b3da4d285bb2197d62624e96be7ea686cd->leave($__internal_165f9bac4a4e7c6591657ea615bd52b3da4d285bb2197d62624e96be7ea686cd_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
